namespace Coze.IntegrationTests;

/// <summary>
/// Contracts that can be checked without an API key.
///
/// Every other test here needs COZE_API_KEY and reports inconclusive without one, so a change to
/// the spec's `$ref` graph could previously be merged on nothing but "it compiles". The spec used
/// to declare CanvasPosition twice - CanvasPosition and CanvasPosition1, the same four properties -
/// and generate.sh now merges them, repointing BackgroundImageDetail at the survivor. Compiling
/// proves the reference resolves; it does not prove the wire format survived.
/// </summary>
[TestClass]
public class OfflineContractsTests
{
    [TestMethod]
    public void CanvasPositionRoundTripsThroughItsWireNames()
    {
        var position = global::Coze.CanvasPosition.FromJson(
            """{"width":300,"height":200,"left":50,"top":100}""");

        Assert.IsNotNull(position);
        Assert.AreEqual(300d, position.Width);
        Assert.AreEqual(200d, position.Height);
        Assert.AreEqual(50d, position.Left);
        Assert.AreEqual(100d, position.Top);

        // AdditionalProperties would swallow a property whose name stopped matching, so an empty
        // bag is what says all four were bound by name rather than silently collected.
        Assert.AreEqual(0, position.AdditionalProperties.Count);

        var roundtrip = global::Coze.CanvasPosition.FromJson(position.ToJson());
        Assert.IsNotNull(roundtrip);
        Assert.AreEqual(300d, roundtrip.Width);
        Assert.AreEqual(100d, roundtrip.Top);
    }

    [TestMethod]
    public void BackgroundImageDetailBindsTheMergedCanvasPosition()
    {
        // The property that carried the duplicate. If the merge had left the $ref dangling or
        // pointing at a differently shaped schema, this is where it would show.
        var detail = global::Coze.BackgroundImageDetail.FromJson(
            """{"canvas_position":{"width":10,"height":20,"left":30,"top":40}}""");

        Assert.IsNotNull(detail);
        Assert.IsNotNull(detail.CanvasPosition);
        Assert.AreEqual(10d, detail.CanvasPosition.Width);
        Assert.AreEqual(40d, detail.CanvasPosition.Top);
    }
}
