
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Sightengine
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Sightengine.JsonConverters.WorkflowCheckResponseSummaryActionJsonConverter),

            typeof(global::Sightengine.JsonConverters.WorkflowCheckResponseSummaryActionNullableJsonConverter),

            typeof(global::Sightengine.JsonConverters.CheckTextRequestModeJsonConverter),

            typeof(global::Sightengine.JsonConverters.CheckTextRequestModeNullableJsonConverter),

            typeof(global::Sightengine.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.RequestInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.MediaInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.NudityResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.SuggestiveClasses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.NudityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.SuggestiveClassesCleavageCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.SuggestiveClassesMaleChestCategories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WeaponResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WeaponResultClasses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.DrugResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.DrugResultClasses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.OffensiveResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.OffensiveResultClasses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.GoreResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.GoreResultClasses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ScamResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.FaceResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.DetectedFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.DetectedFace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.DetectedFaceFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextContentResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.TextContentResultWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextContentResultWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.QrResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.QrResultQrCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.QrResultQrCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.AiGeneratedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ImageTypeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ImageQualityResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ImageCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WorkflowCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WorkflowCheckResponseSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WorkflowCheckResponseSummaryAction), TypeInfoPropertyName = "WorkflowCheckResponseSummaryAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.WorkflowCheckResponseSummaryRejectReasonItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WorkflowCheckResponseSummaryRejectReasonItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.WorkflowCheckResponseWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.VideoFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.VideoFrameInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.VideoCheckSyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.VideoCheckSyncResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.VideoFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.VideoCheckAsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ProfanityMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.PersonalMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.LinkMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextCheckResponseProfanity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.ProfanityMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextCheckResponsePersonal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.PersonalMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextCheckResponseLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Sightengine.LinkMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.TextCheckResponseMisleading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.FeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.CheckImageByUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.CheckWorkflowByUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.CheckVideoSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.CheckVideoAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.CheckTextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.CheckTextRequestMode), TypeInfoPropertyName = "CheckTextRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sightengine.SubmitFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.DetectedFace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.TextContentResultWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.QrResultQrCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.WorkflowCheckResponseSummaryRejectReasonItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.VideoFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.ProfanityMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.PersonalMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Sightengine.LinkMatch>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}