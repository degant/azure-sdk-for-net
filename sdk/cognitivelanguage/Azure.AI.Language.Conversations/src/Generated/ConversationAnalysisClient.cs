// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The ConversationAnalysis service client. </summary>
    public partial class ConversationAnalysisClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ConversationAnalysisClient for mocking. </summary>
        protected ConversationAnalysisClient()
        {
        }

        /// <summary> Initializes a new instance of ConversationAnalysisClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt;resource-name&gt;.cognitiveservices.azure.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ConversationAnalysisClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new ConversationAnalysisClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ConversationAnalysisClient. </summary>
        /// <param name="endpoint"> Supported Cognitive Services endpoint (e.g., https://&lt;resource-name&gt;.cognitiveservices.azure.com). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ConversationAnalysisClient(Uri endpoint, AzureKeyCredential credential, ConversationAnalysisClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ConversationAnalysisClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Analyzes the input conversation utterance. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// <details><summary>ConversationalTask</summary>Schema for <c>ConversationalTask</c>:
        /// <code>{
        ///   kind: Conversation, # Required. Enumeration of supported Conversation tasks.
        ///   analysisInput: {
        ///     conversationItem: {
        ///       id: string, # Required. The ID of a conversation item.
        ///       participantId: string, # Required. The participant ID of a conversation item.
        ///       language: string, # Optional. The override language of a conversation item in BCP 47 language representation.
        ///       modality: &quot;transcript&quot; | &quot;text&quot;, # Optional. Enumeration of supported conversational modalities.
        ///     }, # Required. The abstract base for a user input formatted conversation (e.g., Text, Transcript).
        ///   }, # Required. The input ConversationItem and its optional parameters
        ///   parameters: {
        ///     projectName: string, # Required. The name of the project to use.
        ///     deploymentName: string, # Required. The name of the deployment to use.
        ///     verbose: boolean, # Optional. If true, the service will return more detailed information in the response.
        ///     isLoggingEnabled: boolean, # Optional. If true, the service will keep the query for further review.
        ///     stringIndexType: &quot;TextElements_v8&quot; | &quot;UnicodeCodePoint&quot; | &quot;Utf16CodeUnit&quot;, # Optional. Specifies the method used to interpret string offsets. Set this to &quot;Utf16CodeUnit&quot; for .NET strings, which are encoded as UTF-16.
        ///     directTarget: string, # Optional. The name of a target project to forward the request to.
        ///     targetProjectParameters: Dictionary&lt;string, AnalysisParameters&gt;, # Optional. A dictionary representing the parameters for each target project.
        ///   }, # Required. Input parameters necessary for a Conversation task.
        /// }
        /// </code>
        /// </details>
        /// 
        /// Response Body:
        /// 
        /// <details><summary>ConversationalTaskResult</summary>Schema for <c>ConversationalTaskResult</c>:
        /// <code>{
        ///   kind: ConversationResult, # Required. Enumeration of supported conversational task results
        ///   result: {
        ///     query: string, # Required. The conversation utterance given by the caller.
        ///     detectedLanguage: string, # Optional. The system detected language for the query in BCP 47 language representation..
        ///     prediction: {
        ///       projectKind: &quot;Conversation&quot; | &quot;Orchestration&quot;, # Required. The type of the project.
        ///       topIntent: string, # Optional. The intent with the highest score.
        ///     }, # Required. The prediction result of a conversation project.
        ///   }, # Required. Represents a conversation analysis response.
        /// }
        /// </code>
        /// </details>
        /// 
        /// </remarks>
        public virtual async Task<Response> AnalyzeConversationAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeConversationRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyzes the input conversation utterance. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// <details><summary>ConversationalTask</summary>Schema for <c>ConversationalTask</c>:
        /// <code>{
        ///   kind: Conversation, # Required. Enumeration of supported Conversation tasks.
        ///   analysisInput: {
        ///     conversationItem: {
        ///       id: string, # Required. The ID of a conversation item.
        ///       participantId: string, # Required. The participant ID of a conversation item.
        ///       language: string, # Optional. The override language of a conversation item in BCP 47 language representation.
        ///       modality: &quot;transcript&quot; | &quot;text&quot;, # Optional. Enumeration of supported conversational modalities.
        ///     }, # Required. The abstract base for a user input formatted conversation (e.g., Text, Transcript).
        ///   }, # Required. The input ConversationItem and its optional parameters
        ///   parameters: {
        ///     projectName: string, # Required. The name of the project to use.
        ///     deploymentName: string, # Required. The name of the deployment to use.
        ///     verbose: boolean, # Optional. If true, the service will return more detailed information in the response.
        ///     isLoggingEnabled: boolean, # Optional. If true, the service will keep the query for further review.
        ///     stringIndexType: &quot;TextElements_v8&quot; | &quot;UnicodeCodePoint&quot; | &quot;Utf16CodeUnit&quot;, # Optional. Specifies the method used to interpret string offsets. Set this to &quot;Utf16CodeUnit&quot; for .NET strings, which are encoded as UTF-16.
        ///     directTarget: string, # Optional. The name of a target project to forward the request to.
        ///     targetProjectParameters: Dictionary&lt;string, AnalysisParameters&gt;, # Optional. A dictionary representing the parameters for each target project.
        ///   }, # Required. Input parameters necessary for a Conversation task.
        /// }
        /// </code>
        /// </details>
        /// 
        /// Response Body:
        /// 
        /// <details><summary>ConversationalTaskResult</summary>Schema for <c>ConversationalTaskResult</c>:
        /// <code>{
        ///   kind: ConversationResult, # Required. Enumeration of supported conversational task results
        ///   result: {
        ///     query: string, # Required. The conversation utterance given by the caller.
        ///     detectedLanguage: string, # Optional. The system detected language for the query in BCP 47 language representation..
        ///     prediction: {
        ///       projectKind: &quot;Conversation&quot; | &quot;Orchestration&quot;, # Required. The type of the project.
        ///       topIntent: string, # Optional. The intent with the highest score.
        ///     }, # Required. The prediction result of a conversation project.
        ///   }, # Required. Represents a conversation analysis response.
        /// }
        /// </code>
        /// </details>
        /// 
        /// </remarks>
        public virtual Response AnalyzeConversation(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeConversationRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateAnalyzeConversationRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/:analyze-conversations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
