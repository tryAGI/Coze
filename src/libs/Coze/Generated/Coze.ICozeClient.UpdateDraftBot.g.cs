#nullable enable

namespace Coze
{
    public partial interface ICozeClient
    {
        /// <summary>
        /// 更新智能体<br/>
        /// {"0":{"ops":[{"insert":"更新智能体的配置。\n"},{"insert":"通过此 API 可更新通过扣子编程或 API 方式创建的所有智能体。通过 API 方式修改智能体除了智能体名称和描述、头像、人设与回复逻辑及开场白之外，还支持为智能体绑定知识库和插件。\n"},{"attributes":{"anchor":"a7f3d685","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不支持通过 API 绑定火山知识库，只能绑定扣子知识库。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Coze.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.UpdateDraftBotResponse> UpdateDraftBotAsync(

            global::Coze.UpdateDraftBotRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 更新智能体<br/>
        /// {"0":{"ops":[{"insert":"更新智能体的配置。\n"},{"insert":"通过此 API 可更新通过扣子编程或 API 方式创建的所有智能体。通过 API 方式修改智能体除了智能体名称和描述、头像、人设与回复逻辑及开场白之外，还支持为智能体绑定知识库和插件。\n"},{"attributes":{"anchor":"a7f3d685","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"不支持通过 API 绑定火山知识库，只能绑定扣子知识库。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="description"></param>
        /// <param name="iconFileId"></param>
        /// <param name="knowledge"></param>
        /// <param name="mediaConfig"></param>
        /// <param name="modelInfoConfig"></param>
        /// <param name="name"></param>
        /// <param name="onboardingInfo"></param>
        /// <param name="pluginIdList"></param>
        /// <param name="promptInfo"></param>
        /// <param name="suggestReplyInfo"></param>
        /// <param name="workflowIdList"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Coze.UpdateDraftBotResponse> UpdateDraftBotAsync(
            string botId,
            string? description = default,
            string? iconFileId = default,
            global::Coze.PropertiesKnowledge? knowledge = default,
            global::Coze.PropertiesMediaConfig? mediaConfig = default,
            global::Coze.PropertiesModelInfoConfig? modelInfoConfig = default,
            string? name = default,
            global::Coze.PropertiesOnboardingInfo? onboardingInfo = default,
            global::Coze.PropertiesPluginIdList? pluginIdList = default,
            global::Coze.PropertiesPromptInfo? promptInfo = default,
            global::Coze.PropertiesSuggestReplyInfo? suggestReplyInfo = default,
            global::Coze.PropertiesWorkflowIdList? workflowIdList = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}