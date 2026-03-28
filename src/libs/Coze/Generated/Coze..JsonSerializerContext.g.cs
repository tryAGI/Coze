
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ResponseDetail), TypeInfoPropertyName = "ResponseDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Emotion), TypeInfoPropertyName = "Emotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EmotionInfo), TypeInfoPropertyName = "EmotionInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Interval), TypeInfoPropertyName = "Interval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVoiceData), TypeInfoPropertyName = "OpenAPIVoiceData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVoiceState), TypeInfoPropertyName = "OpenAPIVoiceState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EmotionInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AudioSpeechData), TypeInfoPropertyName = "AudioSpeechData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]), TypeInfoPropertyName = "ByteArray")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AudioTranscriptionsData), TypeInfoPropertyName = "AudioTranscriptionsData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListVoiceData), TypeInfoPropertyName = "ListVoiceData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenAPIVoiceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UserConfig), TypeInfoPropertyName = "UserConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.UserConfigEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UserConfigEnum), TypeInfoPropertyName = "UserConfigEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishStatus), TypeInfoPropertyName = "PublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChunkStrategy), TypeInfoPropertyName = "ChunkStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CrawlContent), TypeInfoPropertyName = "CrawlContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Pagination), TypeInfoPropertyName = "Pagination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDatasetOpenApiData), TypeInfoPropertyName = "CreateDatasetOpenApiData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Dataset), TypeInfoPropertyName = "Dataset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DocumentBase), TypeInfoPropertyName = "DocumentBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SourceInfo), TypeInfoPropertyName = "SourceInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateRule), TypeInfoPropertyName = "UpdateRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DocumentInfo), TypeInfoPropertyName = "DocumentInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DocumentProgress), TypeInfoPropertyName = "DocumentProgress2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FilterStrategy), TypeInfoPropertyName = "FilterStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenApiData), TypeInfoPropertyName = "GetDocumentProgressOpenApiData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.DocumentProgress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.IndexStrategy), TypeInfoPropertyName = "IndexStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDatasetOpenApiData), TypeInfoPropertyName = "ListDatasetOpenApiData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListPhotoOpenApiData), TypeInfoPropertyName = "ListPhotoOpenApiData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PhotoInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PhotoInfo), TypeInfoPropertyName = "PhotoInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ParsingStrategy), TypeInfoPropertyName = "ParsingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SinkStrategy), TypeInfoPropertyName = "SinkStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TabValue), TypeInfoPropertyName = "TabValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TableColumn), TypeInfoPropertyName = "TableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TableSheet), TypeInfoPropertyName = "TableSheet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VolcanoDataset), TypeInfoPropertyName = "VolcanoDataset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetVariableData), TypeInfoPropertyName = "GetVariableData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.KVItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.KVItem), TypeInfoPropertyName = "KVItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageContentExpand), TypeInfoPropertyName = "ChatMessageContentExpand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageContentExpandType), TypeInfoPropertyName = "ChatMessageContentExpandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatMessageExpandType), TypeInfoPropertyName = "ChatMessageExpandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3ChatDetail), TypeInfoPropertyName = "ChatV3ChatDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.LastError), TypeInfoPropertyName = "LastError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RequiredAction), TypeInfoPropertyName = "RequiredAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Usage2), TypeInfoPropertyName = "Usage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3MessageDetail), TypeInfoPropertyName = "ChatV3MessageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CompletionUsage1), TypeInfoPropertyName = "CompletionUsage12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InsertedAdditionalMessage), TypeInfoPropertyName = "InsertedAdditionalMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InterruptFunction), TypeInfoPropertyName = "InterruptFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InterruptPlugin), TypeInfoPropertyName = "InterruptPlugin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.InterruptRequireInfo), TypeInfoPropertyName = "InterruptRequireInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptUsage), TypeInfoPropertyName = "PromptUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputs), TypeInfoPropertyName = "SubmitToolOutputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.InterruptPlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TimeCost1), TypeInfoPropertyName = "TimeCost12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CompletionUsage), TypeInfoPropertyName = "CompletionUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ConversationData), TypeInfoPropertyName = "ConversationData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1), TypeInfoPropertyName = "EnterMessage12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1ContentType), TypeInfoPropertyName = "EnterMessage1ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1Role), TypeInfoPropertyName = "EnterMessage1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage1Type), TypeInfoPropertyName = "EnterMessage1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListConversationData), TypeInfoPropertyName = "ListConversationData_Coze_ListConversationData")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ConversationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApi), TypeInfoPropertyName = "OpenMessageApi2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiContentType), TypeInfoPropertyName = "OpenMessageApiContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiRole), TypeInfoPropertyName = "OpenMessageApiRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenMessageApiType), TypeInfoPropertyName = "OpenMessageApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptUsage1), TypeInfoPropertyName = "PromptUsage12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Section), TypeInfoPropertyName = "Section2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TimeCost), TypeInfoPropertyName = "TimeCost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Usage), TypeInfoPropertyName = "Usage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ApiInfo), TypeInfoPropertyName = "ApiInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageDetail), TypeInfoPropertyName = "BackgroundImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CanvasPosition1), TypeInfoPropertyName = "CanvasPosition12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GradientPosition1), TypeInfoPropertyName = "GradientPosition12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageInfo1), TypeInfoPropertyName = "BackgroundImageInfo12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BotConfig), TypeInfoPropertyName = "BotConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BotInfo), TypeInfoPropertyName = "BotInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CommonKnowledge), TypeInfoPropertyName = "CommonKnowledge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModelInfo), TypeInfoPropertyName = "ModelInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OnboardingInfoV2), TypeInfoPropertyName = "OnboardingInfoV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PluginInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PluginInfo), TypeInfoPropertyName = "PluginInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptInfo), TypeInfoPropertyName = "PromptInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ShortcutCommandInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandInfo), TypeInfoPropertyName = "ShortcutCommandInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.Variable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Variable), TypeInfoPropertyName = "Variable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Voice), TypeInfoPropertyName = "Voice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.WorkflowInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowInfo), TypeInfoPropertyName = "WorkflowInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CacheType), TypeInfoPropertyName = "CacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.KnowledgeInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.KnowledgeInfo), TypeInfoPropertyName = "KnowledgeInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CustomConfig), TypeInfoPropertyName = "CustomConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModelConfig), TypeInfoPropertyName = "ModelConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2), TypeInfoPropertyName = "EnterMessage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2ContentType), TypeInfoPropertyName = "EnterMessage2ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2Role), TypeInfoPropertyName = "EnterMessage2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage2Type), TypeInfoPropertyName = "EnterMessage2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ApiInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PrefixPromptInfo), TypeInfoPropertyName = "PrefixPromptInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PromptMode), TypeInfoPropertyName = "PromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishDraftBotData), TypeInfoPropertyName = "PublishDraftBotData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishStatus1), TypeInfoPropertyName = "PublishStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RegenerateParam), TypeInfoPropertyName = "RegenerateParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandComponent), TypeInfoPropertyName = "ShortcutCommandComponent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandDetail), TypeInfoPropertyName = "ShortcutCommandDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ShortcutCommandComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutCommandToolInfo), TypeInfoPropertyName = "ShortcutCommandToolInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutSendType), TypeInfoPropertyName = "ShortcutSendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ShortcutToolParam), TypeInfoPropertyName = "ShortcutToolParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpacePublishedBots), TypeInfoPropertyName = "SpacePublishedBots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpacePublishedBotsInfo), TypeInfoPropertyName = "SpacePublishedBotsInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.SpacePublishedBots>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.StreamMode), TypeInfoPropertyName = "StreamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SuggestReplyMode), TypeInfoPropertyName = "SuggestReplyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ToolOutput), TypeInfoPropertyName = "ToolOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VariableChannel), TypeInfoPropertyName = "VariableChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VariableType), TypeInfoPropertyName = "VariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VoiceData), TypeInfoPropertyName = "VoiceData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.File), TypeInfoPropertyName = "File2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListWorkspaceScope), TypeInfoPropertyName = "ListWorkspaceScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCreateSpaceRet), TypeInfoPropertyName = "OpenCreateSpaceRet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenRemoveSpaceMemberData), TypeInfoPropertyName = "OpenRemoveSpaceMemberData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpace), TypeInfoPropertyName = "OpenSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SpaceMemberJoinedStatus), TypeInfoPropertyName = "SpaceMemberJoinedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpaceData), TypeInfoPropertyName = "OpenSpaceData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpaceMember), TypeInfoPropertyName = "OpenSpaceMember2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkspaceRoleType), TypeInfoPropertyName = "WorkspaceRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSpaceMemberListData), TypeInfoPropertyName = "OpenSpaceMemberListData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenSpaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AudioConfig), TypeInfoPropertyName = "AudioConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.VoiceConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.VoiceConfig), TypeInfoPropertyName = "VoiceConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AvatarConfig), TypeInfoPropertyName = "AvatarConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageDetail1), TypeInfoPropertyName = "BackgroundImageDetail12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CanvasPosition), TypeInfoPropertyName = "CanvasPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GradientPosition), TypeInfoPropertyName = "GradientPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BackgroundImageInfo), TypeInfoPropertyName = "BackgroundImageInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatFlowRole), TypeInfoPropertyName = "ChatFlowRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OnboardingInfo), TypeInfoPropertyName = "OnboardingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SuggestReplyInfo1), TypeInfoPropertyName = "SuggestReplyInfo12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UserInputConfig), TypeInfoPropertyName = "UserInputConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterMessage), TypeInfoPropertyName = "EnterMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Interrupt), TypeInfoPropertyName = "Interrupt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.OpenAPIParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParameter), TypeInfoPropertyName = "OpenAPIParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.NodeExecuteStatus), TypeInfoPropertyName = "NodeExecuteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIEndReturnType), TypeInfoPropertyName = "OpenAPIEndReturnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIListVersionData), TypeInfoPropertyName = "OpenAPIListVersionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenAPIVersionMetaInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIVersionMetaInfo), TypeInfoPropertyName = "OpenAPIVersionMetaInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParamType), TypeInfoPropertyName = "OpenAPIParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIParameterType), TypeInfoPropertyName = "OpenAPIParameterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUserInfo), TypeInfoPropertyName = "OpenAPIUserInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowInput), TypeInfoPropertyName = "OpenAPIWorkflowInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowOutput), TypeInfoPropertyName = "OpenAPIWorkflowOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowBasic), TypeInfoPropertyName = "OpenAPIWorkflowBasic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowList), TypeInfoPropertyName = "OpenAPIWorkflowList2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenAPIWorkflowBasic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIWorkflowMode), TypeInfoPropertyName = "OpenAPIWorkflowMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.Usage1), TypeInfoPropertyName = "Usage12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowExecuteHistory), TypeInfoPropertyName = "WorkflowExecuteHistory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.NodeExecuteStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowInfo1), TypeInfoPropertyName = "WorkflowInfo12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.WorkflowNodeExecuteHistory), TypeInfoPropertyName = "WorkflowNodeExecuteHistory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.EnterpriseMemberRole), TypeInfoPropertyName = "EnterpriseMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListOrganizationPeopleData), TypeInfoPropertyName = "ListOrganizationPeopleData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OrganizationPeople>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeople), TypeInfoPropertyName = "OrganizationPeople2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeopleOrganizationRoleType), TypeInfoPropertyName = "OrganizationPeopleOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationPeoplePeopleType), TypeInfoPropertyName = "OrganizationPeoplePeopleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OrganizationRoleType), TypeInfoPropertyName = "OrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PeopleType), TypeInfoPropertyName = "PeopleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ApiAppOpenV2), TypeInfoPropertyName = "ApiAppOpenV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.AppTypeOpen), TypeInfoPropertyName = "AppTypeOpen2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.BotSimpleInfo), TypeInfoPropertyName = "BotSimpleInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FolderSimpleInfo), TypeInfoPropertyName = "FolderSimpleInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.FolderType), TypeInfoPropertyName = "FolderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetApiAppListOpenRespData), TypeInfoPropertyName = "GetApiAppListOpenRespData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ApiAppOpenV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCopyTaskInfoData), TypeInfoPropertyName = "OpenCopyTaskInfoData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskEntityType), TypeInfoPropertyName = "TaskEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.TaskFailedReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskFailedReason), TypeInfoPropertyName = "TaskFailedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenDuplicateDraftEntityData), TypeInfoPropertyName = "OpenDuplicateDraftEntityData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotData), TypeInfoPropertyName = "OpenGetBotData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.BotSimpleInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetSpaceFolderData), TypeInfoPropertyName = "OpenGetSpaceFolderData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.FolderSimpleInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesAudio), TypeInfoPropertyName = "PropertiesAudio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesBenefitInfo), TypeInfoPropertyName = "PropertiesBenefitInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesCollaboratorsItems), TypeInfoPropertyName = "PropertiesCollaboratorsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfig), TypeInfoPropertyName = "PropertiesConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesAudioConfig), TypeInfoPropertyName = "PropertiesConfigPropertiesAudioConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigRoomMode), TypeInfoPropertyName = "PropertiesConfigRoomMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTurnDetection), TypeInfoPropertyName = "PropertiesConfigPropertiesTurnDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesVideoConfig), TypeInfoPropertyName = "PropertiesConfigPropertiesVideoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTranslateConfig), TypeInfoPropertyName = "PropertiesConfigPropertiesTranslateConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesConfigPropertiesTurnDetectionType), TypeInfoPropertyName = "PropertiesConfigPropertiesTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesData), TypeInfoPropertyName = "PropertiesData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBasicInfo), TypeInfoPropertyName = "PropertiesDataPropertiesBasicInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItems), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBasicInfoUserLevel), TypeInfoPropertyName = "PropertiesDataPropertiesBasicInfoUserLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfo), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesBasic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsBenefitType), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsBenefitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesEffective2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfo), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesBenefitInfosItems), TypeInfoPropertyName = "PropertiesDataPropertiesBenefitInfosItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesItemsItems), TypeInfoPropertyName = "PropertiesDataPropertiesItemsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesItemsItemsPropertiesCreator), TypeInfoPropertyName = "PropertiesDataPropertiesItemsItemsPropertiesCreator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDataPropertiesTaskInfosItems), TypeInfoPropertyName = "PropertiesDataPropertiesTaskInfosItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesDetail), TypeInfoPropertyName = "PropertiesDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptData), TypeInfoPropertyName = "PropertiesInterruptData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties), TypeInfoPropertyName = "PropertiesInterruptDataPropertiesRequiredParametersAdditionalProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType), TypeInfoPropertyName = "PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesKnowledge), TypeInfoPropertyName = "PropertiesKnowledge2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesMediaConfig), TypeInfoPropertyName = "PropertiesMediaConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfig), TypeInfoPropertyName = "PropertiesModelInfoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfigApiMode), TypeInfoPropertyName = "PropertiesModelInfoConfigApiMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesModelInfoConfigCacheType), TypeInfoPropertyName = "PropertiesModelInfoConfigCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOnboardingInfo), TypeInfoPropertyName = "PropertiesOnboardingInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOrganizationPeopleItems), TypeInfoPropertyName = "PropertiesOrganizationPeopleItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesOrganizationPeopleItemsOrganizationRoleType), TypeInfoPropertyName = "PropertiesOrganizationPeopleItemsOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPluginIdList), TypeInfoPropertyName = "PropertiesPluginIdList2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesPluginIdListPropertiesIdListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPluginIdListPropertiesIdListItems), TypeInfoPropertyName = "PropertiesPluginIdListPropertiesIdListItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfo), TypeInfoPropertyName = "PropertiesPromptInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfoPropertiesPrefixPromptInfo), TypeInfoPropertyName = "PropertiesPromptInfoPropertiesPrefixPromptInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesPromptInfoPromptMode), TypeInfoPropertyName = "PropertiesPromptInfoPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesSuggestReplyInfo), TypeInfoPropertyName = "PropertiesSuggestReplyInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesSuggestReplyInfoReplyMode), TypeInfoPropertyName = "PropertiesSuggestReplyInfoReplyMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsage), TypeInfoPropertyName = "PropertiesUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsersItems), TypeInfoPropertyName = "PropertiesUsersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesUsersItemsRole), TypeInfoPropertyName = "PropertiesUsersItemsRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesWorkflowIdList), TypeInfoPropertyName = "PropertiesWorkflowIdList2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesWorkflowIdListPropertiesIdsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PropertiesWorkflowIdListPropertiesIdsItems), TypeInfoPropertyName = "PropertiesWorkflowIdListPropertiesIdsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequest), TypeInfoPropertyName = "ChatSDKRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestAuth), TypeInfoPropertyName = "ChatSDKRequestAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfig), TypeInfoPropertyName = "ChatSDKRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigAppInfo), TypeInfoPropertyName = "ChatSDKRequestConfigAppInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigBotInfo), TypeInfoPropertyName = "ChatSDKRequestConfigBotInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestConfigType), TypeInfoPropertyName = "ChatSDKRequestConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUi), TypeInfoPropertyName = "ChatSDKRequestUi2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiAsstBtn), TypeInfoPropertyName = "ChatSDKRequestUiAsstBtn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiBase), TypeInfoPropertyName = "ChatSDKRequestUiBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBot), TypeInfoPropertyName = "ChatSDKRequestUiChatBot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBotFeedback), TypeInfoPropertyName = "ChatSDKRequestUiChatBotFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanel), TypeInfoPropertyName = "ChatSDKRequestUiChatBotFeedbackFeedbackPanel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag), TypeInfoPropertyName = "ChatSDKRequestUiChatBotFeedbackFeedbackPanelTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiConversations), TypeInfoPropertyName = "ChatSDKRequestUiConversations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiFooter), TypeInfoPropertyName = "ChatSDKRequestUiFooter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUiHeader), TypeInfoPropertyName = "ChatSDKRequestUiHeader2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatSDKRequestUserInfo), TypeInfoPropertyName = "ChatSDKRequestUserInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIRequest), TypeInfoPropertyName = "CreateDocumentOpenAPIRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.DocumentBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIRequest), TypeInfoPropertyName = "DeleteDocumentAPIRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIRequest), TypeInfoPropertyName = "ListDocumentOpenAPIRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UibuilderRequest), TypeInfoPropertyName = "UibuilderRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UibuilderRequestUi), TypeInfoPropertyName = "UibuilderRequestUi2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UibuilderRequestUserInfo), TypeInfoPropertyName = "UibuilderRequestUserInfo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenRequest), TypeInfoPropertyName = "CreateApiAppOpenRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenRequestAppType), TypeInfoPropertyName = "CreateApiAppOpenRequestAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateApiAppOpenRequest), TypeInfoPropertyName = "UpdateApiAppOpenRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubscribeApiAppEventOpenRequest), TypeInfoPropertyName = "SubscribeApiAppEventOpenRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddAppCollaboratorRequest), TypeInfoPropertyName = "OpenAPIAddAppCollaboratorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesCollaboratorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCreateRoomRequest), TypeInfoPropertyName = "PublicCreateRoomRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequest), TypeInfoPropertyName = "PublicAudioSpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequestEmotion), TypeInfoPropertyName = "PublicAudioSpeechRequestEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechRequestResponseFormat), TypeInfoPropertyName = "PublicAudioSpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioTranscriptionsRequest), TypeInfoPropertyName = "PublicAudioTranscriptionsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCloneVoiceRequest), TypeInfoPropertyName = "PublicCloneVoiceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDraftBotRequest), TypeInfoPropertyName = "CreateDraftBotRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishDraftBotRequest), TypeInfoPropertyName = "PublishDraftBotRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDraftBotRequest), TypeInfoPropertyName = "UpdateDraftBotRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeRequest), TypeInfoPropertyName = "OpenSwitchBotDevelopModeRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeRequestCollaborationMode), TypeInfoPropertyName = "OpenSwitchBotDevelopModeRequestCollaborationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddBotCollaboratorRequest), TypeInfoPropertyName = "OpenAPIAddBotCollaboratorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUnpublishBotRequest), TypeInfoPropertyName = "OpenAPIUnpublishBotRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateBenefitLimitationRequest), TypeInfoPropertyName = "CreateBenefitLimitationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIInstallConnectorToWorkspaceRequest), TypeInfoPropertyName = "OpenAPIInstallConnectorToWorkspaceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBindConnectorUserConfigRequest), TypeInfoPropertyName = "OpenAPIBindConnectorUserConfigRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.UserConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateConversationApiRequest), TypeInfoPropertyName = "CreateConversationApiRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EnterMessage1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequest), TypeInfoPropertyName = "CreateMessageApiRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequestContentType), TypeInfoPropertyName = "CreateMessageApiRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiRequestRole), TypeInfoPropertyName = "CreateMessageApiRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiRequest), TypeInfoPropertyName = "ListMessageApiRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiRequestOrder), TypeInfoPropertyName = "ListMessageApiRequestOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiRequest), TypeInfoPropertyName = "ModifyMessageApiRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiRequestContentType), TypeInfoPropertyName = "ModifyMessageApiRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateConversationApiRequest), TypeInfoPropertyName = "UpdateConversationApiRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDatasetOpenAPIRequest), TypeInfoPropertyName = "UpdateDatasetOpenAPIRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIRequest), TypeInfoPropertyName = "GetDocumentProgressOpenAPIRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddEnterpriseMemberRequest), TypeInfoPropertyName = "OpenAPIAddEnterpriseMemberRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesUsersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequest), TypeInfoPropertyName = "OpenAPIUpdateEnterpriseMemberRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberRequestRole), TypeInfoPropertyName = "OpenAPIUpdateEnterpriseMemberRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPICreateOrganizationRequest), TypeInfoPropertyName = "OpenAPICreateOrganizationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenDuplicateDraftEntityRequest), TypeInfoPropertyName = "OpenDuplicateDraftEntityRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UploadFileOpenRequest), TypeInfoPropertyName = "UploadFileOpenRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationRequest), TypeInfoPropertyName = "OpenAPIUpdateOrganizationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBatchAddOrganizationPeopleRequest), TypeInfoPropertyName = "OpenAPIBatchAddOrganizationPeopleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.PropertiesOrganizationPeopleItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequest), TypeInfoPropertyName = "OpenAPIUpdateOrganizationPeopleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType), TypeInfoPropertyName = "OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRunFlowRequest), TypeInfoPropertyName = "OpenAPIRunFlowRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamResumeFlowRequest), TypeInfoPropertyName = "OpenAPIStreamResumeFlowRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamRunFlowRequest), TypeInfoPropertyName = "OpenAPIStreamRunFlowRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeRequest), TypeInfoPropertyName = "OpenAPIToggleCollaborationModeRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeRequestCollaborationMode), TypeInfoPropertyName = "OpenAPIToggleCollaborationModeRequestCollaborationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddWorkflowCollaboratorRequest), TypeInfoPropertyName = "OpenAPIAddWorkflowCollaboratorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIChatFlowRunRequest), TypeInfoPropertyName = "OpenAPIChatFlowRunRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EnterMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIResumeFlowRequest), TypeInfoPropertyName = "OpenAPIResumeFlowRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCreateSpaceRequest), TypeInfoPropertyName = "OpenCreateSpaceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenUpdateSpaceRequest), TypeInfoPropertyName = "OpenUpdateSpaceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenRemoveSpaceMemberRequest), TypeInfoPropertyName = "OpenRemoveSpaceMemberRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3Request), TypeInfoPropertyName = "ChatV3Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.EnterMessage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3RequestPublishStatus), TypeInfoPropertyName = "ChatV3RequestPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CancelChatApiRequest), TypeInfoPropertyName = "CancelChatApiRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsRequest), TypeInfoPropertyName = "SubmitToolOutputsRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ToolOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIAgwJsConv), TypeInfoPropertyName = "CreateDocumentOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIAgwJsConv), TypeInfoPropertyName = "DeleteDocumentAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIAgwJsConv), TypeInfoPropertyName = "ListDocumentOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetProjectListPublishStatus), TypeInfoPropertyName = "OpenGetProjectListPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotListPublishStatus), TypeInfoPropertyName = "OpenGetBotListPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenListBotVersionsPublishStatus), TypeInfoPropertyName = "OpenListBotVersionsPublishStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIAgwJsConv), TypeInfoPropertyName = "GetDocumentProgressOpenAPIAgwJsConv2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDocumentOpenAPIResponse), TypeInfoPropertyName = "CreateDocumentOpenAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.DocumentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteDocumentAPIResponse), TypeInfoPropertyName = "DeleteDocumentAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDocumentOpenAPIResponse), TypeInfoPropertyName = "ListDocumentOpenAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateApiAppOpenResponse), TypeInfoPropertyName = "CreateApiAppOpenResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateApiAppOpenResponse), TypeInfoPropertyName = "UpdateApiAppOpenResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubscribeApiAppEventOpenResponse), TypeInfoPropertyName = "SubscribeApiAppEventOpenResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetProjectListResponse), TypeInfoPropertyName = "OpenGetProjectListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddAppCollaboratorResponse), TypeInfoPropertyName = "OpenAPIAddAppCollaboratorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRemoveAppCollaboratorResponse), TypeInfoPropertyName = "OpenAPIRemoveAppCollaboratorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCreateRoomResponse), TypeInfoPropertyName = "PublicCreateRoomResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioSpeechResponse), TypeInfoPropertyName = "PublicAudioSpeechResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicAudioTranscriptionsResponse), TypeInfoPropertyName = "PublicAudioTranscriptionsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicListVoiceResponse), TypeInfoPropertyName = "PublicListVoiceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublicCloneVoiceResponse), TypeInfoPropertyName = "PublicCloneVoiceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateDraftBotResponse), TypeInfoPropertyName = "CreateDraftBotResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetBotOnlineInfoResponse), TypeInfoPropertyName = "GetBotOnlineInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.PublishDraftBotResponse), TypeInfoPropertyName = "PublishDraftBotResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDraftBotResponse), TypeInfoPropertyName = "UpdateDraftBotResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotListResponse), TypeInfoPropertyName = "OpenGetBotListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetBotInfoResponse), TypeInfoPropertyName = "OpenGetBotInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenSwitchBotDevelopModeResponse), TypeInfoPropertyName = "OpenSwitchBotDevelopModeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddBotCollaboratorResponse), TypeInfoPropertyName = "OpenAPIAddBotCollaboratorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRemoveBotCollaboratorResponse), TypeInfoPropertyName = "OpenAPIRemoveBotCollaboratorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUnpublishBotResponse), TypeInfoPropertyName = "OpenAPIUnpublishBotResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenListBotVersionsResponse), TypeInfoPropertyName = "OpenListBotVersionsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OapiGetEnterpriseBenefitResponse), TypeInfoPropertyName = "OapiGetEnterpriseBenefitResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OapiListBillDownloadTaskResponse), TypeInfoPropertyName = "OapiListBillDownloadTaskResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateBenefitLimitationResponse), TypeInfoPropertyName = "CreateBenefitLimitationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIInstallConnectorToWorkspaceResponse), TypeInfoPropertyName = "OpenAPIInstallConnectorToWorkspaceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBindConnectorUserConfigResponse), TypeInfoPropertyName = "OpenAPIBindConnectorUserConfigResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateConversationApiResponse), TypeInfoPropertyName = "CreateConversationApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CreateMessageApiResponse), TypeInfoPropertyName = "CreateMessageApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteMessageApiResponse), TypeInfoPropertyName = "DeleteMessageApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListMessageApiResponse), TypeInfoPropertyName = "ListMessageApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.OpenMessageApi>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ModifyMessageApiResponse), TypeInfoPropertyName = "ModifyMessageApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveMessageApiResponse), TypeInfoPropertyName = "RetrieveMessageApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveConversationApiResponse), TypeInfoPropertyName = "RetrieveConversationApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListConversationsApiResponse), TypeInfoPropertyName = "ListConversationsApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateConversationApiResponse), TypeInfoPropertyName = "UpdateConversationApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ClearConversationApiResponse), TypeInfoPropertyName = "ClearConversationApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.DeleteFeedbackResponse), TypeInfoPropertyName = "DeleteFeedbackResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListDatasetOpenAPIResponse), TypeInfoPropertyName = "ListDatasetOpenAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UpdateDatasetOpenAPIResponse), TypeInfoPropertyName = "UpdateDatasetOpenAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListPhotoDocumentOpenAPIResponse), TypeInfoPropertyName = "ListPhotoDocumentOpenAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponse), TypeInfoPropertyName = "GetDocumentProgressOpenAPIResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponseData), TypeInfoPropertyName = "GetDocumentProgressOpenAPIResponseData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.GetDocumentProgressOpenAPIResponseDataDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponseDataDataItem), TypeInfoPropertyName = "GetDocumentProgressOpenAPIResponseDataDataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetDocumentProgressOpenAPIResponseDetail), TypeInfoPropertyName = "GetDocumentProgressOpenAPIResponseDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddEnterpriseMemberResponse), TypeInfoPropertyName = "OpenAPIAddEnterpriseMemberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateEnterpriseMemberResponse), TypeInfoPropertyName = "OpenAPIUpdateEnterpriseMemberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPICreateOrganizationResponse), TypeInfoPropertyName = "OpenAPICreateOrganizationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenDuplicateDraftEntityResponse), TypeInfoPropertyName = "OpenDuplicateDraftEntityResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCopyTaskInfoResponse), TypeInfoPropertyName = "OpenCopyTaskInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveFileOpenResponse), TypeInfoPropertyName = "RetrieveFileOpenResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.UploadFileOpenResponse), TypeInfoPropertyName = "UploadFileOpenResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetSpaceFolderResponse), TypeInfoPropertyName = "OpenGetSpaceFolderResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetFolderInfoResponse), TypeInfoPropertyName = "OpenGetFolderInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationResponse), TypeInfoPropertyName = "OpenAPIUpdateOrganizationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIBatchAddOrganizationPeopleResponse), TypeInfoPropertyName = "OpenAPIBatchAddOrganizationPeopleResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIUpdateOrganizationPeopleResponse), TypeInfoPropertyName = "OpenAPIUpdateOrganizationPeopleResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.GetSpacePublishedBotsListResponse), TypeInfoPropertyName = "GetSpacePublishedBotsListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenGetPlaygroundVariableResponse), TypeInfoPropertyName = "OpenGetPlaygroundVariableResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRunFlowResponse), TypeInfoPropertyName = "OpenAPIRunFlowResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamResumeFlowResponse), TypeInfoPropertyName = "OpenAPIStreamResumeFlowResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIStreamRunFlowResponse), TypeInfoPropertyName = "OpenAPIStreamRunFlowResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetWorkflowListResponse), TypeInfoPropertyName = "OpenAPIGetWorkflowListResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetWorkflowInfoResponse), TypeInfoPropertyName = "OpenAPIGetWorkflowInfoResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIToggleCollaborationModeResponse), TypeInfoPropertyName = "OpenAPIToggleCollaborationModeResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIAddWorkflowCollaboratorResponse), TypeInfoPropertyName = "OpenAPIAddWorkflowCollaboratorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIRemoveWorkflowCollaboratorResponse), TypeInfoPropertyName = "OpenAPIRemoveWorkflowCollaboratorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetWorkflowRunHistoryResponse), TypeInfoPropertyName = "OpenAPIGetWorkflowRunHistoryResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.WorkflowExecuteHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIGetNodeExecuteHistoryResponse), TypeInfoPropertyName = "OpenAPIGetNodeExecuteHistoryResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIListVersionResponse), TypeInfoPropertyName = "OpenAPIListVersionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIChatFlowRunResponse), TypeInfoPropertyName = "OpenAPIChatFlowRunResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenAPIResumeFlowResponse), TypeInfoPropertyName = "OpenAPIResumeFlowResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenCreateSpaceResponse), TypeInfoPropertyName = "OpenCreateSpaceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenUpdateSpaceResponse), TypeInfoPropertyName = "OpenUpdateSpaceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.OpenRemoveSpaceMemberResponse), TypeInfoPropertyName = "OpenRemoveSpaceMemberResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3Response), TypeInfoPropertyName = "ChatV3Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3Response2), TypeInfoPropertyName = "ChatV3Response22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ChatV3ResponseEvent), TypeInfoPropertyName = "ChatV3ResponseEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.CancelChatApiResponse), TypeInfoPropertyName = "CancelChatApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.ListChatMessageApiResponse), TypeInfoPropertyName = "ListChatMessageApiResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Coze.ChatV3MessageDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.RetrieveChatOpenResponse), TypeInfoPropertyName = "RetrieveChatOpenResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsResponse), TypeInfoPropertyName = "SubmitToolOutputsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Coze.SubmitToolOutputsResponse2), TypeInfoPropertyName = "SubmitToolOutputsResponse22")]
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