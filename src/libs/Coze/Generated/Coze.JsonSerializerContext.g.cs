
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Coze
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListConversationData), TypeInfoPropertyName = "ListConversationData_Coze_ListConversationData")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ConversationData>), TypeInfoPropertyName = "ListConversationData_System_Collections_Generic_List_global_Coze_ConversationData")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Emotion), TypeInfoPropertyName = "Emotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EmotionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Interval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVoiceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVoiceState), TypeInfoPropertyName = "OpenAPIVoiceState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EmotionInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AudioSpeechData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AudioTranscriptionsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListVoiceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenAPIVoiceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UserConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.UserConfigEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UserConfigEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishStatus), TypeInfoPropertyName = "PublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChunkStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CrawlContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDatasetOpenApiData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.StorageConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DocumentBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SourceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DocumentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DocumentProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FilterStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenApiData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.DocumentProgress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.IndexStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDatasetOpenApiData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListPhotoOpenApiData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PhotoInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PhotoInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ParsingStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SinkStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.StorageStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TabValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TableSheet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VolcanoDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetVariableData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.KVItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.KVItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageContentExpand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageContentExpandType), TypeInfoPropertyName = "ChatMessageContentExpandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageExpandType), TypeInfoPropertyName = "ChatMessageExpandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3ChatDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.LastError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RequiredAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Usage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3MessageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CompletionUsage1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InsertedAdditionalMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InterruptFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InterruptPlugin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InterruptRequireInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.InterruptPlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TimeCost1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ConversationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1ContentType), TypeInfoPropertyName = "EnterMessage1ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1Role), TypeInfoPropertyName = "EnterMessage1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1Type), TypeInfoPropertyName = "EnterMessage1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ConversationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiContentType), TypeInfoPropertyName = "OpenMessageApiContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiRole), TypeInfoPropertyName = "OpenMessageApiRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiType), TypeInfoPropertyName = "OpenMessageApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptUsage1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Section))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TimeCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ApiInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CanvasPosition1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GradientPosition1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageInfo1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BotConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BotInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CommonKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OnboardingInfoV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PluginInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PluginInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ShortcutCommandInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.Variable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Variable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.WorkflowInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CacheType), TypeInfoPropertyName = "CacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.KnowledgeInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.KnowledgeInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CustomConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2ContentType), TypeInfoPropertyName = "EnterMessage2ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2Role), TypeInfoPropertyName = "EnterMessage2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2Type), TypeInfoPropertyName = "EnterMessage2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ApiInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PrefixPromptInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptMode), TypeInfoPropertyName = "PromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishDraftBotData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishStatus1), TypeInfoPropertyName = "PublishStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RegenerateParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandComponent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ShortcutCommandComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandToolInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutSendType), TypeInfoPropertyName = "ShortcutSendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpacePublishedBots))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpacePublishedBotsInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.SpacePublishedBots>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.StreamMode), TypeInfoPropertyName = "StreamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SuggestReplyInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SuggestReplyMode), TypeInfoPropertyName = "SuggestReplyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ToolOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VariableChannel), TypeInfoPropertyName = "VariableChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VariableType), TypeInfoPropertyName = "VariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VoiceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListWorkspaceScope), TypeInfoPropertyName = "ListWorkspaceScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCreateSpaceRet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenRemoveSpaceMemberData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpaceMemberJoinedStatus), TypeInfoPropertyName = "SpaceMemberJoinedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpaceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpaceMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkspaceRoleType), TypeInfoPropertyName = "WorkspaceRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpaceMemberListData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenSpaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.VoiceConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AvatarConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageDetail1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CanvasPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GradientPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatFlowRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OnboardingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SuggestReplyInfo1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UserInputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Interrupt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.OpenAPIParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.NodeExecuteStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIEndReturnType), TypeInfoPropertyName = "OpenAPIEndReturnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIListVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenAPIVersionMetaInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVersionMetaInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParamType), TypeInfoPropertyName = "OpenAPIParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParameterType), TypeInfoPropertyName = "OpenAPIParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUserInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenAPIWorkflowBasic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowMode), TypeInfoPropertyName = "OpenAPIWorkflowMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Usage1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowExecuteHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.NodeExecuteStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowInfo1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowNodeExecuteHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterpriseMemberRole), TypeInfoPropertyName = "EnterpriseMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListOrganizationPeopleData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OrganizationPeople>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeople))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeopleOrganizationRoleType), TypeInfoPropertyName = "OrganizationPeopleOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeoplePeopleType), TypeInfoPropertyName = "OrganizationPeoplePeopleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationRoleType), TypeInfoPropertyName = "OrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PeopleType), TypeInfoPropertyName = "PeopleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ApiAppOpenV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AppTypeOpen), TypeInfoPropertyName = "AppTypeOpen2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BotSimpleInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FolderSimpleInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FolderType), TypeInfoPropertyName = "FolderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetApiAppListOpenRespData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ApiAppOpenV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCopyTaskInfoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskEntityType), TypeInfoPropertyName = "TaskEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.TaskFailedReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskFailedReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenDuplicateDraftEntityData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.BotSimpleInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetSpaceFolderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.FolderSimpleInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesBenefitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesCollaboratorsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesAudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigRoomMode), TypeInfoPropertyName = "PropertiesConfigRoomMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesVideoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTranslateConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType), TypeInfoPropertyName = "PropertiesConfigPropertiesTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBasicInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel), TypeInfoPropertyName = "PropertiesDataPropertiesBasicInfoUserLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsBenefitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfosItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesItemsItemsPropertiesCreator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesTaskInfosItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType), TypeInfoPropertyName = "PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesKnowledge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesMediaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfigApiMode), TypeInfoPropertyName = "PropertiesModelInfoConfigApiMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfigCacheType), TypeInfoPropertyName = "PropertiesModelInfoConfigCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOnboardingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOrganizationPeopleItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType), TypeInfoPropertyName = "PropertiesOrganizationPeopleItemsOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPluginIdList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesPluginIdListPropertiesIdListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPluginIdListPropertiesIdListItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfoPropertiesPrefixPromptInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfoPromptMode), TypeInfoPropertyName = "PropertiesPromptInfoPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesSuggestReplyInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode), TypeInfoPropertyName = "PropertiesSuggestReplyInfoReplyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsersItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsersItemsRole), TypeInfoPropertyName = "PropertiesUsersItemsRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesWorkflowIdList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesWorkflowIdListPropertiesIdsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesWorkflowIdListPropertiesIdsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigAppInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigBotInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigType), TypeInfoPropertyName = "ChatSDKRequestConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiAsstBtn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBotFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiConversations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiFooter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUserInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.DocumentBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UibuilderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UibuilderRequestUi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UibuilderRequestUserInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenRequestAppType), TypeInfoPropertyName = "CreateApiAppOpenRequestAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateApiAppOpenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubscribeApiAppEventOpenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddAppCollaboratorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesCollaboratorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCreateRoomRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequestEmotion), TypeInfoPropertyName = "PublicAudioSpeechRequestEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequestResponseFormat), TypeInfoPropertyName = "PublicAudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioTranscriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCloneVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDraftBotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishDraftBotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDraftBotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode), TypeInfoPropertyName = "OpenSwitchBotDevelopModeRequestCollaborationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddBotCollaboratorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUnpublishBotRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateBenefitLimitationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIInstallConnectorToWorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBindConnectorUserConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.UserConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateConversationApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EnterMessage1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequestContentType), TypeInfoPropertyName = "CreateMessageApiRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequestRole), TypeInfoPropertyName = "CreateMessageApiRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiRequestOrder), TypeInfoPropertyName = "ListMessageApiRequestOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiRequestContentType), TypeInfoPropertyName = "ModifyMessageApiRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateConversationApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDatasetOpenAPIRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddEnterpriseMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesUsersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole), TypeInfoPropertyName = "OpenAPIUpdateEnterpriseMemberRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPICreateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenDuplicateDraftEntityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UploadFileOpenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBatchAddOrganizationPeopleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesOrganizationPeopleItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType), TypeInfoPropertyName = "OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRunFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamResumeFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamRunFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode), TypeInfoPropertyName = "OpenAPIToggleCollaborationModeRequestCollaborationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddWorkflowCollaboratorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIChatFlowRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EnterMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIResumeFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCreateSpaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenUpdateSpaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenRemoveSpaceMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EnterMessage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3RequestPublishStatus), TypeInfoPropertyName = "ChatV3RequestPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CancelChatApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv), TypeInfoPropertyName = "CreateDocumentOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIAgwJsConv), TypeInfoPropertyName = "DeleteDocumentAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIAgwJsConv), TypeInfoPropertyName = "ListDocumentOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetProjectListPublishStatus), TypeInfoPropertyName = "OpenGetProjectListPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotListPublishStatus), TypeInfoPropertyName = "OpenGetBotListPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenListBotVersionsPublishStatus), TypeInfoPropertyName = "OpenListBotVersionsPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv), TypeInfoPropertyName = "GetDocumentProgressOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.DocumentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateApiAppOpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubscribeApiAppEventOpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetProjectListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddAppCollaboratorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRemoveAppCollaboratorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCreateRoomResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioTranscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicListVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCloneVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDraftBotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetBotOnlineInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishDraftBotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDraftBotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddBotCollaboratorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRemoveBotCollaboratorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUnpublishBotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenListBotVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OapiGetEnterpriseBenefitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OapiListBillDownloadTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateBenefitLimitationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIInstallConnectorToWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBindConnectorUserConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateConversationApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteMessageApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenMessageApi>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveMessageApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveConversationApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListConversationsApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateConversationApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ClearConversationApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDatasetOpenAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDatasetOpenAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListPhotoDocumentOpenAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.GetDocumentProgressOpenAPIResponseDataDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponseDataDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddEnterpriseMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPICreateOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenDuplicateDraftEntityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCopyTaskInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveFileOpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UploadFileOpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetSpaceFolderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetFolderInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBatchAddOrganizationPeopleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetSpacePublishedBotsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetPlaygroundVariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRunFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamResumeFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamRunFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetWorkflowListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetWorkflowInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddWorkflowCollaboratorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRemoveWorkflowCollaboratorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetWorkflowRunHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.WorkflowExecuteHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetNodeExecuteHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIListVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIChatFlowRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIResumeFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCreateSpaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenUpdateSpaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenRemoveSpaceMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3ResponseEvent), TypeInfoPropertyName = "ChatV3ResponseEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CancelChatApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListChatMessageApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ChatV3MessageDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveChatOpenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsResponseEvent), TypeInfoPropertyName = "SubmitToolOutputsResponseEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Emotion?), TypeInfoPropertyName = "NullableEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVoiceState?), TypeInfoPropertyName = "NullableOpenAPIVoiceState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishStatus?), TypeInfoPropertyName = "NullablePublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageContentExpandType?), TypeInfoPropertyName = "NullableChatMessageContentExpandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageExpandType?), TypeInfoPropertyName = "NullableChatMessageExpandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1ContentType?), TypeInfoPropertyName = "NullableEnterMessage1ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1Role?), TypeInfoPropertyName = "NullableEnterMessage1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1Type?), TypeInfoPropertyName = "NullableEnterMessage1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FeedbackType?), TypeInfoPropertyName = "NullableFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiContentType?), TypeInfoPropertyName = "NullableOpenMessageApiContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiRole?), TypeInfoPropertyName = "NullableOpenMessageApiRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiType?), TypeInfoPropertyName = "NullableOpenMessageApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CacheType?), TypeInfoPropertyName = "NullableCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2ContentType?), TypeInfoPropertyName = "NullableEnterMessage2ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2Role?), TypeInfoPropertyName = "NullableEnterMessage2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2Type?), TypeInfoPropertyName = "NullableEnterMessage2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptMode?), TypeInfoPropertyName = "NullablePromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishStatus1?), TypeInfoPropertyName = "NullablePublishStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutSendType?), TypeInfoPropertyName = "NullableShortcutSendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.StreamMode?), TypeInfoPropertyName = "NullableStreamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SuggestReplyMode?), TypeInfoPropertyName = "NullableSuggestReplyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VariableChannel?), TypeInfoPropertyName = "NullableVariableChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VariableType?), TypeInfoPropertyName = "NullableVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListWorkspaceScope?), TypeInfoPropertyName = "NullableListWorkspaceScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpaceMemberJoinedStatus?), TypeInfoPropertyName = "NullableSpaceMemberJoinedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkspaceRoleType?), TypeInfoPropertyName = "NullableWorkspaceRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIEndReturnType?), TypeInfoPropertyName = "NullableOpenAPIEndReturnType2")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListConversationData), TypeInfoPropertyName = "ListConversationData_Coze_ListConversationData")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ConversationData>), TypeInfoPropertyName = "ListConversationData_System_Collections_Generic_List_global_Coze_ConversationData")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParamType?), TypeInfoPropertyName = "NullableOpenAPIParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParameterType?), TypeInfoPropertyName = "NullableOpenAPIParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowMode?), TypeInfoPropertyName = "NullableOpenAPIWorkflowMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterpriseMemberRole?), TypeInfoPropertyName = "NullableEnterpriseMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeopleOrganizationRoleType?), TypeInfoPropertyName = "NullableOrganizationPeopleOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeoplePeopleType?), TypeInfoPropertyName = "NullableOrganizationPeoplePeopleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationRoleType?), TypeInfoPropertyName = "NullableOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PeopleType?), TypeInfoPropertyName = "NullablePeopleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AppTypeOpen?), TypeInfoPropertyName = "NullableAppTypeOpen2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FolderType?), TypeInfoPropertyName = "NullableFolderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskEntityType?), TypeInfoPropertyName = "NullableTaskEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskStatus?), TypeInfoPropertyName = "NullableTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigRoomMode?), TypeInfoPropertyName = "NullablePropertiesConfigRoomMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType?), TypeInfoPropertyName = "NullablePropertiesConfigPropertiesTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBasicInfoUserLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsBenefitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy?), TypeInfoPropertyName = "NullablePropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType?), TypeInfoPropertyName = "NullablePropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfigApiMode?), TypeInfoPropertyName = "NullablePropertiesModelInfoConfigApiMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfigCacheType?), TypeInfoPropertyName = "NullablePropertiesModelInfoConfigCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType?), TypeInfoPropertyName = "NullablePropertiesOrganizationPeopleItemsOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfoPromptMode?), TypeInfoPropertyName = "NullablePropertiesPromptInfoPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode?), TypeInfoPropertyName = "NullablePropertiesSuggestReplyInfoReplyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsersItemsRole?), TypeInfoPropertyName = "NullablePropertiesUsersItemsRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigType?), TypeInfoPropertyName = "NullableChatSDKRequestConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenRequestAppType?), TypeInfoPropertyName = "NullableCreateApiAppOpenRequestAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequestEmotion?), TypeInfoPropertyName = "NullablePublicAudioSpeechRequestEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequestResponseFormat?), TypeInfoPropertyName = "NullablePublicAudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode?), TypeInfoPropertyName = "NullableOpenSwitchBotDevelopModeRequestCollaborationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequestContentType?), TypeInfoPropertyName = "NullableCreateMessageApiRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequestRole?), TypeInfoPropertyName = "NullableCreateMessageApiRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiRequestOrder?), TypeInfoPropertyName = "NullableListMessageApiRequestOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiRequestContentType?), TypeInfoPropertyName = "NullableModifyMessageApiRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole?), TypeInfoPropertyName = "NullableOpenAPIUpdateEnterpriseMemberRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType?), TypeInfoPropertyName = "NullableOpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode?), TypeInfoPropertyName = "NullableOpenAPIToggleCollaborationModeRequestCollaborationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3RequestPublishStatus?), TypeInfoPropertyName = "NullableChatV3RequestPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv?), TypeInfoPropertyName = "NullableCreateDocumentOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIAgwJsConv?), TypeInfoPropertyName = "NullableDeleteDocumentAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIAgwJsConv?), TypeInfoPropertyName = "NullableListDocumentOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetProjectListPublishStatus?), TypeInfoPropertyName = "NullableOpenGetProjectListPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotListPublishStatus?), TypeInfoPropertyName = "NullableOpenGetBotListPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenListBotVersionsPublishStatus?), TypeInfoPropertyName = "NullableOpenListBotVersionsPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv?), TypeInfoPropertyName = "NullableGetDocumentProgressOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3ResponseEvent?), TypeInfoPropertyName = "NullableChatV3ResponseEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsResponseEvent?), TypeInfoPropertyName = "NullableSubmitToolOutputsResponseEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.EmotionInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OpenAPIVoiceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.UserConfigEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.DocumentProgress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PhotoInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.KVItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.InterruptPlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PluginInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ShortcutCommandInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.Variable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.WorkflowInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.KnowledgeInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ApiInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ShortcutCommandComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.SpacePublishedBots>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OpenSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OpenSpaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OpenAPIVersionMetaInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OpenAPIWorkflowBasic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OrganizationPeople>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ApiAppOpenV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.TaskFailedReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.BotSimpleInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.FolderSimpleInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesDataPropertiesBenefitInfoItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesPluginIdListPropertiesIdListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesWorkflowIdListPropertiesIdsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.DocumentBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesCollaboratorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.UserConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.EnterMessage1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesUsersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.PropertiesOrganizationPeopleItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.EnterMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.EnterMessage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.DocumentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.OpenMessageApi>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.GetDocumentProgressOpenAPIResponseDataDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.WorkflowExecuteHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ChatV3MessageDetail>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Coze.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Coze.Emotion)

                    || typeToConvert == typeof(global::Coze.Emotion?)

                    || typeToConvert == typeof(global::Coze.OpenAPIVoiceState)

                    || typeToConvert == typeof(global::Coze.OpenAPIVoiceState?)

                    || typeToConvert == typeof(global::Coze.PublishStatus)

                    || typeToConvert == typeof(global::Coze.PublishStatus?)

                    || typeToConvert == typeof(global::Coze.ChatMessageContentExpandType)

                    || typeToConvert == typeof(global::Coze.ChatMessageContentExpandType?)

                    || typeToConvert == typeof(global::Coze.ChatMessageExpandType)

                    || typeToConvert == typeof(global::Coze.ChatMessageExpandType?)

                    || typeToConvert == typeof(global::Coze.EnterMessage1ContentType)

                    || typeToConvert == typeof(global::Coze.EnterMessage1ContentType?)

                    || typeToConvert == typeof(global::Coze.EnterMessage1Role)

                    || typeToConvert == typeof(global::Coze.EnterMessage1Role?)

                    || typeToConvert == typeof(global::Coze.EnterMessage1Type)

                    || typeToConvert == typeof(global::Coze.EnterMessage1Type?)

                    || typeToConvert == typeof(global::Coze.FeedbackType)

                    || typeToConvert == typeof(global::Coze.FeedbackType?)

                    || typeToConvert == typeof(global::Coze.OpenMessageApiContentType)

                    || typeToConvert == typeof(global::Coze.OpenMessageApiContentType?)

                    || typeToConvert == typeof(global::Coze.OpenMessageApiRole)

                    || typeToConvert == typeof(global::Coze.OpenMessageApiRole?)

                    || typeToConvert == typeof(global::Coze.OpenMessageApiType)

                    || typeToConvert == typeof(global::Coze.OpenMessageApiType?)

                    || typeToConvert == typeof(global::Coze.CacheType)

                    || typeToConvert == typeof(global::Coze.CacheType?)

                    || typeToConvert == typeof(global::Coze.EnterMessage2ContentType)

                    || typeToConvert == typeof(global::Coze.EnterMessage2ContentType?)

                    || typeToConvert == typeof(global::Coze.EnterMessage2Role)

                    || typeToConvert == typeof(global::Coze.EnterMessage2Role?)

                    || typeToConvert == typeof(global::Coze.EnterMessage2Type)

                    || typeToConvert == typeof(global::Coze.EnterMessage2Type?)

                    || typeToConvert == typeof(global::Coze.PromptMode)

                    || typeToConvert == typeof(global::Coze.PromptMode?)

                    || typeToConvert == typeof(global::Coze.PublishStatus1)

                    || typeToConvert == typeof(global::Coze.PublishStatus1?)

                    || typeToConvert == typeof(global::Coze.ShortcutSendType)

                    || typeToConvert == typeof(global::Coze.ShortcutSendType?)

                    || typeToConvert == typeof(global::Coze.StreamMode)

                    || typeToConvert == typeof(global::Coze.StreamMode?)

                    || typeToConvert == typeof(global::Coze.SuggestReplyMode)

                    || typeToConvert == typeof(global::Coze.SuggestReplyMode?)

                    || typeToConvert == typeof(global::Coze.VariableChannel)

                    || typeToConvert == typeof(global::Coze.VariableChannel?)

                    || typeToConvert == typeof(global::Coze.VariableType)

                    || typeToConvert == typeof(global::Coze.VariableType?)

                    || typeToConvert == typeof(global::Coze.ListWorkspaceScope)

                    || typeToConvert == typeof(global::Coze.ListWorkspaceScope?)

                    || typeToConvert == typeof(global::Coze.SpaceMemberJoinedStatus)

                    || typeToConvert == typeof(global::Coze.SpaceMemberJoinedStatus?)

                    || typeToConvert == typeof(global::Coze.WorkspaceRoleType)

                    || typeToConvert == typeof(global::Coze.WorkspaceRoleType?)

                    || typeToConvert == typeof(global::Coze.OpenAPIEndReturnType)

                    || typeToConvert == typeof(global::Coze.OpenAPIEndReturnType?)

                    || typeToConvert == typeof(global::Coze.OpenAPIParamType)

                    || typeToConvert == typeof(global::Coze.OpenAPIParamType?)

                    || typeToConvert == typeof(global::Coze.OpenAPIParameterType)

                    || typeToConvert == typeof(global::Coze.OpenAPIParameterType?)

                    || typeToConvert == typeof(global::Coze.OpenAPIWorkflowMode)

                    || typeToConvert == typeof(global::Coze.OpenAPIWorkflowMode?)

                    || typeToConvert == typeof(global::Coze.EnterpriseMemberRole)

                    || typeToConvert == typeof(global::Coze.EnterpriseMemberRole?)

                    || typeToConvert == typeof(global::Coze.OrganizationPeopleOrganizationRoleType)

                    || typeToConvert == typeof(global::Coze.OrganizationPeopleOrganizationRoleType?)

                    || typeToConvert == typeof(global::Coze.OrganizationPeoplePeopleType)

                    || typeToConvert == typeof(global::Coze.OrganizationPeoplePeopleType?)

                    || typeToConvert == typeof(global::Coze.OrganizationRoleType)

                    || typeToConvert == typeof(global::Coze.OrganizationRoleType?)

                    || typeToConvert == typeof(global::Coze.PeopleType)

                    || typeToConvert == typeof(global::Coze.PeopleType?)

                    || typeToConvert == typeof(global::Coze.AppTypeOpen)

                    || typeToConvert == typeof(global::Coze.AppTypeOpen?)

                    || typeToConvert == typeof(global::Coze.FolderType)

                    || typeToConvert == typeof(global::Coze.FolderType?)

                    || typeToConvert == typeof(global::Coze.TaskEntityType)

                    || typeToConvert == typeof(global::Coze.TaskEntityType?)

                    || typeToConvert == typeof(global::Coze.TaskStatus)

                    || typeToConvert == typeof(global::Coze.TaskStatus?)

                    || typeToConvert == typeof(global::Coze.PropertiesConfigRoomMode)

                    || typeToConvert == typeof(global::Coze.PropertiesConfigRoomMode?)

                    || typeToConvert == typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType)

                    || typeToConvert == typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus?)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy)

                    || typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy?)

                    || typeToConvert == typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType)

                    || typeToConvert == typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType?)

                    || typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigApiMode)

                    || typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigApiMode?)

                    || typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigCacheType)

                    || typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigCacheType?)

                    || typeToConvert == typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType)

                    || typeToConvert == typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType?)

                    || typeToConvert == typeof(global::Coze.PropertiesPromptInfoPromptMode)

                    || typeToConvert == typeof(global::Coze.PropertiesPromptInfoPromptMode?)

                    || typeToConvert == typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode)

                    || typeToConvert == typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode?)

                    || typeToConvert == typeof(global::Coze.PropertiesUsersItemsRole)

                    || typeToConvert == typeof(global::Coze.PropertiesUsersItemsRole?)

                    || typeToConvert == typeof(global::Coze.ChatSDKRequestConfigType)

                    || typeToConvert == typeof(global::Coze.ChatSDKRequestConfigType?)

                    || typeToConvert == typeof(global::Coze.CreateApiAppOpenRequestAppType)

                    || typeToConvert == typeof(global::Coze.CreateApiAppOpenRequestAppType?)

                    || typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestEmotion)

                    || typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestEmotion?)

                    || typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestResponseFormat)

                    || typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestResponseFormat?)

                    || typeToConvert == typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode)

                    || typeToConvert == typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode?)

                    || typeToConvert == typeof(global::Coze.CreateMessageApiRequestContentType)

                    || typeToConvert == typeof(global::Coze.CreateMessageApiRequestContentType?)

                    || typeToConvert == typeof(global::Coze.CreateMessageApiRequestRole)

                    || typeToConvert == typeof(global::Coze.CreateMessageApiRequestRole?)

                    || typeToConvert == typeof(global::Coze.ListMessageApiRequestOrder)

                    || typeToConvert == typeof(global::Coze.ListMessageApiRequestOrder?)

                    || typeToConvert == typeof(global::Coze.ModifyMessageApiRequestContentType)

                    || typeToConvert == typeof(global::Coze.ModifyMessageApiRequestContentType?)

                    || typeToConvert == typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole)

                    || typeToConvert == typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole?)

                    || typeToConvert == typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType)

                    || typeToConvert == typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType?)

                    || typeToConvert == typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode)

                    || typeToConvert == typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode?)

                    || typeToConvert == typeof(global::Coze.ChatV3RequestPublishStatus)

                    || typeToConvert == typeof(global::Coze.ChatV3RequestPublishStatus?)

                    || typeToConvert == typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv)

                    || typeToConvert == typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv?)

                    || typeToConvert == typeof(global::Coze.DeleteDocumentAPIAgwJsConv)

                    || typeToConvert == typeof(global::Coze.DeleteDocumentAPIAgwJsConv?)

                    || typeToConvert == typeof(global::Coze.ListDocumentOpenAPIAgwJsConv)

                    || typeToConvert == typeof(global::Coze.ListDocumentOpenAPIAgwJsConv?)

                    || typeToConvert == typeof(global::Coze.OpenGetProjectListPublishStatus)

                    || typeToConvert == typeof(global::Coze.OpenGetProjectListPublishStatus?)

                    || typeToConvert == typeof(global::Coze.OpenGetBotListPublishStatus)

                    || typeToConvert == typeof(global::Coze.OpenGetBotListPublishStatus?)

                    || typeToConvert == typeof(global::Coze.OpenListBotVersionsPublishStatus)

                    || typeToConvert == typeof(global::Coze.OpenListBotVersionsPublishStatus?)

                    || typeToConvert == typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv)

                    || typeToConvert == typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv?)

                    || typeToConvert == typeof(global::Coze.ChatV3ResponseEvent)

                    || typeToConvert == typeof(global::Coze.ChatV3ResponseEvent?)

                    || typeToConvert == typeof(global::Coze.SubmitToolOutputsResponseEvent)

                    || typeToConvert == typeof(global::Coze.SubmitToolOutputsResponseEvent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Coze.Emotion))
                {
                    return new global::Coze.JsonConverters.EmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.Emotion?))
                {
                    return new global::Coze.JsonConverters.EmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIVoiceState))
                {
                    return new global::Coze.JsonConverters.OpenAPIVoiceStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIVoiceState?))
                {
                    return new global::Coze.JsonConverters.OpenAPIVoiceStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublishStatus))
                {
                    return new global::Coze.JsonConverters.PublishStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublishStatus?))
                {
                    return new global::Coze.JsonConverters.PublishStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatMessageContentExpandType))
                {
                    return new global::Coze.JsonConverters.ChatMessageContentExpandTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatMessageContentExpandType?))
                {
                    return new global::Coze.JsonConverters.ChatMessageContentExpandTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatMessageExpandType))
                {
                    return new global::Coze.JsonConverters.ChatMessageExpandTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatMessageExpandType?))
                {
                    return new global::Coze.JsonConverters.ChatMessageExpandTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage1ContentType))
                {
                    return new global::Coze.JsonConverters.EnterMessage1ContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage1ContentType?))
                {
                    return new global::Coze.JsonConverters.EnterMessage1ContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage1Role))
                {
                    return new global::Coze.JsonConverters.EnterMessage1RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage1Role?))
                {
                    return new global::Coze.JsonConverters.EnterMessage1RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage1Type))
                {
                    return new global::Coze.JsonConverters.EnterMessage1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage1Type?))
                {
                    return new global::Coze.JsonConverters.EnterMessage1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.FeedbackType))
                {
                    return new global::Coze.JsonConverters.FeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.FeedbackType?))
                {
                    return new global::Coze.JsonConverters.FeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenMessageApiContentType))
                {
                    return new global::Coze.JsonConverters.OpenMessageApiContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenMessageApiContentType?))
                {
                    return new global::Coze.JsonConverters.OpenMessageApiContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenMessageApiRole))
                {
                    return new global::Coze.JsonConverters.OpenMessageApiRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenMessageApiRole?))
                {
                    return new global::Coze.JsonConverters.OpenMessageApiRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenMessageApiType))
                {
                    return new global::Coze.JsonConverters.OpenMessageApiTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenMessageApiType?))
                {
                    return new global::Coze.JsonConverters.OpenMessageApiTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CacheType))
                {
                    return new global::Coze.JsonConverters.CacheTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CacheType?))
                {
                    return new global::Coze.JsonConverters.CacheTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage2ContentType))
                {
                    return new global::Coze.JsonConverters.EnterMessage2ContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage2ContentType?))
                {
                    return new global::Coze.JsonConverters.EnterMessage2ContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage2Role))
                {
                    return new global::Coze.JsonConverters.EnterMessage2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage2Role?))
                {
                    return new global::Coze.JsonConverters.EnterMessage2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage2Type))
                {
                    return new global::Coze.JsonConverters.EnterMessage2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterMessage2Type?))
                {
                    return new global::Coze.JsonConverters.EnterMessage2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PromptMode))
                {
                    return new global::Coze.JsonConverters.PromptModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PromptMode?))
                {
                    return new global::Coze.JsonConverters.PromptModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublishStatus1))
                {
                    return new global::Coze.JsonConverters.PublishStatus1JsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublishStatus1?))
                {
                    return new global::Coze.JsonConverters.PublishStatus1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ShortcutSendType))
                {
                    return new global::Coze.JsonConverters.ShortcutSendTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ShortcutSendType?))
                {
                    return new global::Coze.JsonConverters.ShortcutSendTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.StreamMode))
                {
                    return new global::Coze.JsonConverters.StreamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.StreamMode?))
                {
                    return new global::Coze.JsonConverters.StreamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.SuggestReplyMode))
                {
                    return new global::Coze.JsonConverters.SuggestReplyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.SuggestReplyMode?))
                {
                    return new global::Coze.JsonConverters.SuggestReplyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.VariableChannel))
                {
                    return new global::Coze.JsonConverters.VariableChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.VariableChannel?))
                {
                    return new global::Coze.JsonConverters.VariableChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.VariableType))
                {
                    return new global::Coze.JsonConverters.VariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.VariableType?))
                {
                    return new global::Coze.JsonConverters.VariableTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ListWorkspaceScope))
                {
                    return new global::Coze.JsonConverters.ListWorkspaceScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ListWorkspaceScope?))
                {
                    return new global::Coze.JsonConverters.ListWorkspaceScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.SpaceMemberJoinedStatus))
                {
                    return new global::Coze.JsonConverters.SpaceMemberJoinedStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.SpaceMemberJoinedStatus?))
                {
                    return new global::Coze.JsonConverters.SpaceMemberJoinedStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.WorkspaceRoleType))
                {
                    return new global::Coze.JsonConverters.WorkspaceRoleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.WorkspaceRoleType?))
                {
                    return new global::Coze.JsonConverters.WorkspaceRoleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIEndReturnType))
                {
                    return new global::Coze.JsonConverters.OpenAPIEndReturnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIEndReturnType?))
                {
                    return new global::Coze.JsonConverters.OpenAPIEndReturnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIParamType))
                {
                    return new global::Coze.JsonConverters.OpenAPIParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIParamType?))
                {
                    return new global::Coze.JsonConverters.OpenAPIParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIParameterType))
                {
                    return new global::Coze.JsonConverters.OpenAPIParameterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIParameterType?))
                {
                    return new global::Coze.JsonConverters.OpenAPIParameterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIWorkflowMode))
                {
                    return new global::Coze.JsonConverters.OpenAPIWorkflowModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIWorkflowMode?))
                {
                    return new global::Coze.JsonConverters.OpenAPIWorkflowModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterpriseMemberRole))
                {
                    return new global::Coze.JsonConverters.EnterpriseMemberRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.EnterpriseMemberRole?))
                {
                    return new global::Coze.JsonConverters.EnterpriseMemberRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OrganizationPeopleOrganizationRoleType))
                {
                    return new global::Coze.JsonConverters.OrganizationPeopleOrganizationRoleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OrganizationPeopleOrganizationRoleType?))
                {
                    return new global::Coze.JsonConverters.OrganizationPeopleOrganizationRoleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OrganizationPeoplePeopleType))
                {
                    return new global::Coze.JsonConverters.OrganizationPeoplePeopleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OrganizationPeoplePeopleType?))
                {
                    return new global::Coze.JsonConverters.OrganizationPeoplePeopleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OrganizationRoleType))
                {
                    return new global::Coze.JsonConverters.OrganizationRoleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OrganizationRoleType?))
                {
                    return new global::Coze.JsonConverters.OrganizationRoleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PeopleType))
                {
                    return new global::Coze.JsonConverters.PeopleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PeopleType?))
                {
                    return new global::Coze.JsonConverters.PeopleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.AppTypeOpen))
                {
                    return new global::Coze.JsonConverters.AppTypeOpenJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.AppTypeOpen?))
                {
                    return new global::Coze.JsonConverters.AppTypeOpenNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.FolderType))
                {
                    return new global::Coze.JsonConverters.FolderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.FolderType?))
                {
                    return new global::Coze.JsonConverters.FolderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.TaskEntityType))
                {
                    return new global::Coze.JsonConverters.TaskEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.TaskEntityType?))
                {
                    return new global::Coze.JsonConverters.TaskEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.TaskStatus))
                {
                    return new global::Coze.JsonConverters.TaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.TaskStatus?))
                {
                    return new global::Coze.JsonConverters.TaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesConfigRoomMode))
                {
                    return new global::Coze.JsonConverters.PropertiesConfigRoomModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesConfigRoomMode?))
                {
                    return new global::Coze.JsonConverters.PropertiesConfigRoomModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType))
                {
                    return new global::Coze.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType?))
                {
                    return new global::Coze.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy?))
                {
                    return new global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType))
                {
                    return new global::Coze.JsonConverters.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType?))
                {
                    return new global::Coze.JsonConverters.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigApiMode))
                {
                    return new global::Coze.JsonConverters.PropertiesModelInfoConfigApiModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigApiMode?))
                {
                    return new global::Coze.JsonConverters.PropertiesModelInfoConfigApiModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigCacheType))
                {
                    return new global::Coze.JsonConverters.PropertiesModelInfoConfigCacheTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesModelInfoConfigCacheType?))
                {
                    return new global::Coze.JsonConverters.PropertiesModelInfoConfigCacheTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType))
                {
                    return new global::Coze.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType?))
                {
                    return new global::Coze.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesPromptInfoPromptMode))
                {
                    return new global::Coze.JsonConverters.PropertiesPromptInfoPromptModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesPromptInfoPromptMode?))
                {
                    return new global::Coze.JsonConverters.PropertiesPromptInfoPromptModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode))
                {
                    return new global::Coze.JsonConverters.PropertiesSuggestReplyInfoReplyModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode?))
                {
                    return new global::Coze.JsonConverters.PropertiesSuggestReplyInfoReplyModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesUsersItemsRole))
                {
                    return new global::Coze.JsonConverters.PropertiesUsersItemsRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PropertiesUsersItemsRole?))
                {
                    return new global::Coze.JsonConverters.PropertiesUsersItemsRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatSDKRequestConfigType))
                {
                    return new global::Coze.JsonConverters.ChatSDKRequestConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatSDKRequestConfigType?))
                {
                    return new global::Coze.JsonConverters.ChatSDKRequestConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateApiAppOpenRequestAppType))
                {
                    return new global::Coze.JsonConverters.CreateApiAppOpenRequestAppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateApiAppOpenRequestAppType?))
                {
                    return new global::Coze.JsonConverters.CreateApiAppOpenRequestAppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestEmotion))
                {
                    return new global::Coze.JsonConverters.PublicAudioSpeechRequestEmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestEmotion?))
                {
                    return new global::Coze.JsonConverters.PublicAudioSpeechRequestEmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestResponseFormat))
                {
                    return new global::Coze.JsonConverters.PublicAudioSpeechRequestResponseFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.PublicAudioSpeechRequestResponseFormat?))
                {
                    return new global::Coze.JsonConverters.PublicAudioSpeechRequestResponseFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode))
                {
                    return new global::Coze.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode?))
                {
                    return new global::Coze.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateMessageApiRequestContentType))
                {
                    return new global::Coze.JsonConverters.CreateMessageApiRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateMessageApiRequestContentType?))
                {
                    return new global::Coze.JsonConverters.CreateMessageApiRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateMessageApiRequestRole))
                {
                    return new global::Coze.JsonConverters.CreateMessageApiRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateMessageApiRequestRole?))
                {
                    return new global::Coze.JsonConverters.CreateMessageApiRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ListMessageApiRequestOrder))
                {
                    return new global::Coze.JsonConverters.ListMessageApiRequestOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ListMessageApiRequestOrder?))
                {
                    return new global::Coze.JsonConverters.ListMessageApiRequestOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ModifyMessageApiRequestContentType))
                {
                    return new global::Coze.JsonConverters.ModifyMessageApiRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ModifyMessageApiRequestContentType?))
                {
                    return new global::Coze.JsonConverters.ModifyMessageApiRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole))
                {
                    return new global::Coze.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole?))
                {
                    return new global::Coze.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType))
                {
                    return new global::Coze.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType?))
                {
                    return new global::Coze.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode))
                {
                    return new global::Coze.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode?))
                {
                    return new global::Coze.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatV3RequestPublishStatus))
                {
                    return new global::Coze.JsonConverters.ChatV3RequestPublishStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatV3RequestPublishStatus?))
                {
                    return new global::Coze.JsonConverters.ChatV3RequestPublishStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv))
                {
                    return new global::Coze.JsonConverters.CreateDocumentOpenAPIAgwJsConvJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv?))
                {
                    return new global::Coze.JsonConverters.CreateDocumentOpenAPIAgwJsConvNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.DeleteDocumentAPIAgwJsConv))
                {
                    return new global::Coze.JsonConverters.DeleteDocumentAPIAgwJsConvJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.DeleteDocumentAPIAgwJsConv?))
                {
                    return new global::Coze.JsonConverters.DeleteDocumentAPIAgwJsConvNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ListDocumentOpenAPIAgwJsConv))
                {
                    return new global::Coze.JsonConverters.ListDocumentOpenAPIAgwJsConvJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ListDocumentOpenAPIAgwJsConv?))
                {
                    return new global::Coze.JsonConverters.ListDocumentOpenAPIAgwJsConvNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenGetProjectListPublishStatus))
                {
                    return new global::Coze.JsonConverters.OpenGetProjectListPublishStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenGetProjectListPublishStatus?))
                {
                    return new global::Coze.JsonConverters.OpenGetProjectListPublishStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenGetBotListPublishStatus))
                {
                    return new global::Coze.JsonConverters.OpenGetBotListPublishStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenGetBotListPublishStatus?))
                {
                    return new global::Coze.JsonConverters.OpenGetBotListPublishStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenListBotVersionsPublishStatus))
                {
                    return new global::Coze.JsonConverters.OpenListBotVersionsPublishStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.OpenListBotVersionsPublishStatus?))
                {
                    return new global::Coze.JsonConverters.OpenListBotVersionsPublishStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv))
                {
                    return new global::Coze.JsonConverters.GetDocumentProgressOpenAPIAgwJsConvJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv?))
                {
                    return new global::Coze.JsonConverters.GetDocumentProgressOpenAPIAgwJsConvNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatV3ResponseEvent))
                {
                    return new global::Coze.JsonConverters.ChatV3ResponseEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.ChatV3ResponseEvent?))
                {
                    return new global::Coze.JsonConverters.ChatV3ResponseEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.SubmitToolOutputsResponseEvent))
                {
                    return new global::Coze.JsonConverters.SubmitToolOutputsResponseEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Coze.SubmitToolOutputsResponseEvent?))
                {
                    return new global::Coze.JsonConverters.SubmitToolOutputsResponseEventNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}