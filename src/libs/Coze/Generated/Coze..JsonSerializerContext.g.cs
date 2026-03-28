
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
            typeof(global::Coze.JsonConverters.EmotionJsonConverter),

            typeof(global::Coze.JsonConverters.EmotionNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIVoiceStateJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIVoiceStateNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PublishStatusJsonConverter),

            typeof(global::Coze.JsonConverters.PublishStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ChatMessageContentExpandTypeJsonConverter),

            typeof(global::Coze.JsonConverters.ChatMessageContentExpandTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ChatMessageExpandTypeJsonConverter),

            typeof(global::Coze.JsonConverters.ChatMessageExpandTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage1ContentTypeJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage1ContentTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage1RoleJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage1RoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage1TypeJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage1TypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.FeedbackTypeJsonConverter),

            typeof(global::Coze.JsonConverters.FeedbackTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenMessageApiContentTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenMessageApiContentTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenMessageApiRoleJsonConverter),

            typeof(global::Coze.JsonConverters.OpenMessageApiRoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenMessageApiTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenMessageApiTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.CacheTypeJsonConverter),

            typeof(global::Coze.JsonConverters.CacheTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage2ContentTypeJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage2ContentTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage2RoleJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage2RoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage2TypeJsonConverter),

            typeof(global::Coze.JsonConverters.EnterMessage2TypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PromptModeJsonConverter),

            typeof(global::Coze.JsonConverters.PromptModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PublishStatus1JsonConverter),

            typeof(global::Coze.JsonConverters.PublishStatus1NullableJsonConverter),

            typeof(global::Coze.JsonConverters.ShortcutSendTypeJsonConverter),

            typeof(global::Coze.JsonConverters.ShortcutSendTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.StreamModeJsonConverter),

            typeof(global::Coze.JsonConverters.StreamModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.SuggestReplyModeJsonConverter),

            typeof(global::Coze.JsonConverters.SuggestReplyModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.VariableChannelJsonConverter),

            typeof(global::Coze.JsonConverters.VariableChannelNullableJsonConverter),

            typeof(global::Coze.JsonConverters.VariableTypeJsonConverter),

            typeof(global::Coze.JsonConverters.VariableTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ListWorkspaceScopeJsonConverter),

            typeof(global::Coze.JsonConverters.ListWorkspaceScopeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.SpaceMemberJoinedStatusJsonConverter),

            typeof(global::Coze.JsonConverters.SpaceMemberJoinedStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.WorkspaceRoleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.WorkspaceRoleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIEndReturnTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIEndReturnTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIParamTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIParamTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIParameterTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIParameterTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIWorkflowModeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIWorkflowModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.EnterpriseMemberRoleJsonConverter),

            typeof(global::Coze.JsonConverters.EnterpriseMemberRoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OrganizationPeopleOrganizationRoleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OrganizationPeopleOrganizationRoleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OrganizationPeoplePeopleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OrganizationPeoplePeopleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OrganizationRoleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OrganizationRoleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PeopleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.PeopleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.AppTypeOpenJsonConverter),

            typeof(global::Coze.JsonConverters.AppTypeOpenNullableJsonConverter),

            typeof(global::Coze.JsonConverters.FolderTypeJsonConverter),

            typeof(global::Coze.JsonConverters.FolderTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.TaskEntityTypeJsonConverter),

            typeof(global::Coze.JsonConverters.TaskEntityTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.TaskStatusJsonConverter),

            typeof(global::Coze.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesConfigRoomModeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesConfigRoomModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesModelInfoConfigApiModeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesModelInfoConfigApiModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesModelInfoConfigCacheTypeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesModelInfoConfigCacheTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesPromptInfoPromptModeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesPromptInfoPromptModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesSuggestReplyInfoReplyModeJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesSuggestReplyInfoReplyModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesUsersItemsRoleJsonConverter),

            typeof(global::Coze.JsonConverters.PropertiesUsersItemsRoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ChatSDKRequestConfigTypeJsonConverter),

            typeof(global::Coze.JsonConverters.ChatSDKRequestConfigTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.CreateApiAppOpenRequestAppTypeJsonConverter),

            typeof(global::Coze.JsonConverters.CreateApiAppOpenRequestAppTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PublicAudioSpeechRequestEmotionJsonConverter),

            typeof(global::Coze.JsonConverters.PublicAudioSpeechRequestEmotionNullableJsonConverter),

            typeof(global::Coze.JsonConverters.PublicAudioSpeechRequestResponseFormatJsonConverter),

            typeof(global::Coze.JsonConverters.PublicAudioSpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationModeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.CreateMessageApiRequestContentTypeJsonConverter),

            typeof(global::Coze.JsonConverters.CreateMessageApiRequestContentTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.CreateMessageApiRequestRoleJsonConverter),

            typeof(global::Coze.JsonConverters.CreateMessageApiRequestRoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ListMessageApiRequestOrderJsonConverter),

            typeof(global::Coze.JsonConverters.ListMessageApiRequestOrderNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ModifyMessageApiRequestContentTypeJsonConverter),

            typeof(global::Coze.JsonConverters.ModifyMessageApiRequestContentTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeJsonConverter),

            typeof(global::Coze.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ChatV3RequestPublishStatusJsonConverter),

            typeof(global::Coze.JsonConverters.ChatV3RequestPublishStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.CreateDocumentOpenAPIAgwJsConvJsonConverter),

            typeof(global::Coze.JsonConverters.CreateDocumentOpenAPIAgwJsConvNullableJsonConverter),

            typeof(global::Coze.JsonConverters.DeleteDocumentAPIAgwJsConvJsonConverter),

            typeof(global::Coze.JsonConverters.DeleteDocumentAPIAgwJsConvNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ListDocumentOpenAPIAgwJsConvJsonConverter),

            typeof(global::Coze.JsonConverters.ListDocumentOpenAPIAgwJsConvNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenGetProjectListPublishStatusJsonConverter),

            typeof(global::Coze.JsonConverters.OpenGetProjectListPublishStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenGetBotListPublishStatusJsonConverter),

            typeof(global::Coze.JsonConverters.OpenGetBotListPublishStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.OpenListBotVersionsPublishStatusJsonConverter),

            typeof(global::Coze.JsonConverters.OpenListBotVersionsPublishStatusNullableJsonConverter),

            typeof(global::Coze.JsonConverters.GetDocumentProgressOpenAPIAgwJsConvJsonConverter),

            typeof(global::Coze.JsonConverters.GetDocumentProgressOpenAPIAgwJsConvNullableJsonConverter),

            typeof(global::Coze.JsonConverters.ChatV3ResponseEventJsonConverter),

            typeof(global::Coze.JsonConverters.ChatV3ResponseEventNullableJsonConverter),

            typeof(global::Coze.JsonConverters.SubmitToolOutputsResponseEventJsonConverter),

            typeof(global::Coze.JsonConverters.SubmitToolOutputsResponseEventNullableJsonConverter),

            typeof(global::Coze.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListConversationData), TypeInfoPropertyName = "ListConversationData_Coze_ListConversationData")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Coze.ConversationData>))]
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
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}