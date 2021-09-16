using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ParameterizationStore.Client.Client;
using ParameterizationStore.Client.Model;

namespace ParameterizationStore.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>CaseType</returns>
        CaseType QuipuGmbHParameterizationStore001CaseTypeCodeDelete(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of CaseType</returns>
        ApiResponse<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeDeleteWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>CaseType</returns>
        CaseType QuipuGmbHParameterizationStore001CaseTypeCodeGet(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of CaseType</returns>
        ApiResponse<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeGetWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>CaseTypeFlow</returns>
        CaseTypeFlow QuipuGmbHParameterizationStore001CaseTypeFlowIdDelete(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of CaseTypeFlow</returns>
        ApiResponse<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CaseTypeFlow</returns>
        CaseTypeFlow QuipuGmbHParameterizationStore001CaseTypeFlowPost(CaseTypeFlow body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CaseTypeFlow</returns>
        ApiResponse<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowPostWithHttpInfo(CaseTypeFlow body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CaseTypeFlow</returns>
        CaseTypeFlow QuipuGmbHParameterizationStore001CaseTypeFlowsGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CaseTypeFlow</returns>
        ApiResponse<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowsGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CaseType</returns>
        CaseType QuipuGmbHParameterizationStore001CaseTypePost(CaseType body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CaseType</returns>
        ApiResponse<CaseType> QuipuGmbHParameterizationStore001CaseTypePostWithHttpInfo(CaseType body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void QuipuGmbHParameterizationStore001CaseTypePut(CaseType body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> QuipuGmbHParameterizationStore001CaseTypePutWithHttpInfo(CaseType body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CaseType&gt;</returns>
        List<CaseType> QuipuGmbHParameterizationStore001CaseTypesGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CaseType&gt;</returns>
        ApiResponse<List<CaseType>> QuipuGmbHParameterizationStore001CaseTypesGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void QuipuGmbHParameterizationStore001PingGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> QuipuGmbHParameterizationStore001PingGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ReferenceValue</returns>
        ReferenceValue QuipuGmbHParameterizationStore001ReferenceValueIdDelete(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ReferenceValue</returns>
        ApiResponse<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdDeleteWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ReferenceValue</returns>
        ReferenceValue QuipuGmbHParameterizationStore001ReferenceValueIdGet(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ReferenceValue</returns>
        ApiResponse<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdGetWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ReferenceValue</returns>
        ReferenceValue QuipuGmbHParameterizationStore001ReferenceValuePost(ReferenceValue body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ReferenceValue</returns>
        ApiResponse<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValuePostWithHttpInfo(ReferenceValue body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void QuipuGmbHParameterizationStore001ReferenceValuePut(ReferenceValue body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> QuipuGmbHParameterizationStore001ReferenceValuePutWithHttpInfo(ReferenceValue body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>List&lt;ReferenceValue&gt;</returns>
        List<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValuesCodeGet(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of List&lt;ReferenceValue&gt;</returns>
        ApiResponse<List<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValuesCodeGetWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>StateMachineDefinitionDto</returns>
        StateMachineDefinitionDto QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDelete(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of StateMachineDefinitionDto</returns>
        ApiResponse<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>StateMachineDefinitionDto</returns>
        StateMachineDefinitionDto QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGet(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of StateMachineDefinitionDto</returns>
        ApiResponse<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void QuipuGmbHParameterizationStore001StateMachineDefinitionPost();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> QuipuGmbHParameterizationStore001StateMachineDefinitionPostWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void QuipuGmbHParameterizationStore001StateMachineDefinitionPut();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> QuipuGmbHParameterizationStore001StateMachineDefinitionPutWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;StateMachineDefinitionDto&gt;</returns>
        List<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionsGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;StateMachineDefinitionDto&gt;</returns>
        ApiResponse<List<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionsGetWithHttpInfo();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of CaseType</returns>
        System.Threading.Tasks.Task<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeDeleteAsync(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (CaseType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaseType>> QuipuGmbHParameterizationStore001CaseTypeCodeDeleteAsyncWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of CaseType</returns>
        System.Threading.Tasks.Task<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeGetAsync(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (CaseType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaseType>> QuipuGmbHParameterizationStore001CaseTypeCodeGetAsyncWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of CaseTypeFlow</returns>
        System.Threading.Tasks.Task<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteAsync(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (CaseTypeFlow)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaseTypeFlow>> QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteAsyncWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CaseTypeFlow</returns>
        System.Threading.Tasks.Task<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowPostAsync(CaseTypeFlow body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CaseTypeFlow)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaseTypeFlow>> QuipuGmbHParameterizationStore001CaseTypeFlowPostAsyncWithHttpInfo(CaseTypeFlow body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CaseTypeFlow</returns>
        System.Threading.Tasks.Task<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowsGetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CaseTypeFlow)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaseTypeFlow>> QuipuGmbHParameterizationStore001CaseTypeFlowsGetAsyncWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CaseType</returns>
        System.Threading.Tasks.Task<CaseType> QuipuGmbHParameterizationStore001CaseTypePostAsync(CaseType body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CaseType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CaseType>> QuipuGmbHParameterizationStore001CaseTypePostAsyncWithHttpInfo(CaseType body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task QuipuGmbHParameterizationStore001CaseTypePutAsync(CaseType body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001CaseTypePutAsyncWithHttpInfo(CaseType body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CaseType&gt;</returns>
        System.Threading.Tasks.Task<List<CaseType>> QuipuGmbHParameterizationStore001CaseTypesGetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CaseType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CaseType>>> QuipuGmbHParameterizationStore001CaseTypesGetAsyncWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task QuipuGmbHParameterizationStore001PingGetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001PingGetAsyncWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ReferenceValue</returns>
        System.Threading.Tasks.Task<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdDeleteAsync(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ReferenceValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValueIdDeleteAsyncWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ReferenceValue</returns>
        System.Threading.Tasks.Task<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdGetAsync(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ReferenceValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValueIdGetAsyncWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ReferenceValue</returns>
        System.Threading.Tasks.Task<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValuePostAsync(ReferenceValue body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ReferenceValue)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValuePostAsyncWithHttpInfo(ReferenceValue body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task QuipuGmbHParameterizationStore001ReferenceValuePutAsync(ReferenceValue body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001ReferenceValuePutAsyncWithHttpInfo(ReferenceValue body = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of List&lt;ReferenceValue&gt;</returns>
        System.Threading.Tasks.Task<List<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValuesCodeGetAsync(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (List&lt;ReferenceValue&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ReferenceValue>>> QuipuGmbHParameterizationStore001ReferenceValuesCodeGetAsyncWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of StateMachineDefinitionDto</returns>
        System.Threading.Tasks.Task<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteAsync(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (StateMachineDefinitionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteAsyncWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of StateMachineDefinitionDto</returns>
        System.Threading.Tasks.Task<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetAsync(string code);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (StateMachineDefinitionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetAsyncWithHttpInfo(string code);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task QuipuGmbHParameterizationStore001StateMachineDefinitionPostAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001StateMachineDefinitionPostAsyncWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task QuipuGmbHParameterizationStore001StateMachineDefinitionPutAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001StateMachineDefinitionPutAsyncWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;StateMachineDefinitionDto&gt;</returns>
        System.Threading.Tasks.Task<List<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionsGetAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;StateMachineDefinitionDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StateMachineDefinitionDto>>> QuipuGmbHParameterizationStore001StateMachineDefinitionsGetAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi
    {
        private ParameterizationStore.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new ParameterizationStore.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ParameterizationStore.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// </summary>
        /// <returns></returns>
        public DefaultApi()
        {
            this.Configuration = ParameterizationStore.Client.Client.Configuration.Default;

            ExceptionFactory = ParameterizationStore.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(ParameterizationStore.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ParameterizationStore.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ParameterizationStore.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ParameterizationStore.Client.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ParameterizationStore.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>CaseType</returns>
        public CaseType QuipuGmbHParameterizationStore001CaseTypeCodeDelete(string code)
        {
            ApiResponse<CaseType> localVarResponse = QuipuGmbHParameterizationStore001CaseTypeCodeDeleteWithHttpInfo(code);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of CaseType</returns>
        public ApiResponse<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeDeleteWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001CaseTypeCodeDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeCodeDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseType)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of CaseType</returns>
        public async System.Threading.Tasks.Task<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeDeleteAsync(string code)
        {
            ApiResponse<CaseType> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypeCodeDeleteAsyncWithHttpInfo(code);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (CaseType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaseType>> QuipuGmbHParameterizationStore001CaseTypeCodeDeleteAsyncWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001CaseTypeCodeDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeCodeDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseType)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>CaseType</returns>
        public CaseType QuipuGmbHParameterizationStore001CaseTypeCodeGet(string code)
        {
            ApiResponse<CaseType> localVarResponse = QuipuGmbHParameterizationStore001CaseTypeCodeGetWithHttpInfo(code);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of CaseType</returns>
        public ApiResponse<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeGetWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001CaseTypeCodeGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeCodeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseType)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of CaseType</returns>
        public async System.Threading.Tasks.Task<CaseType> QuipuGmbHParameterizationStore001CaseTypeCodeGetAsync(string code)
        {
            ApiResponse<CaseType> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypeCodeGetAsyncWithHttpInfo(code);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (CaseType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaseType>> QuipuGmbHParameterizationStore001CaseTypeCodeGetAsyncWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001CaseTypeCodeGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeCodeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseType)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>CaseTypeFlow</returns>
        public CaseTypeFlow QuipuGmbHParameterizationStore001CaseTypeFlowIdDelete(string id)
        {
            ApiResponse<CaseTypeFlow> localVarResponse = QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of CaseTypeFlow</returns>
        public ApiResponse<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->QuipuGmbHParameterizationStore001CaseTypeFlowIdDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypeFlow/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeFlowIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseTypeFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseTypeFlow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseTypeFlow)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of CaseTypeFlow</returns>
        public async System.Threading.Tasks.Task<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteAsync(string id)
        {
            ApiResponse<CaseTypeFlow> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteAsyncWithHttpInfo(id);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (CaseTypeFlow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaseTypeFlow>> QuipuGmbHParameterizationStore001CaseTypeFlowIdDeleteAsyncWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->QuipuGmbHParameterizationStore001CaseTypeFlowIdDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypeFlow/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeFlowIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseTypeFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseTypeFlow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseTypeFlow)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CaseTypeFlow</returns>
        public CaseTypeFlow QuipuGmbHParameterizationStore001CaseTypeFlowPost(CaseTypeFlow body = null)
        {
            ApiResponse<CaseTypeFlow> localVarResponse = QuipuGmbHParameterizationStore001CaseTypeFlowPostWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CaseTypeFlow</returns>
        public ApiResponse<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowPostWithHttpInfo(CaseTypeFlow body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypeFlow";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeFlowPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseTypeFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseTypeFlow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseTypeFlow)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CaseTypeFlow</returns>
        public async System.Threading.Tasks.Task<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowPostAsync(CaseTypeFlow body = null)
        {
            ApiResponse<CaseTypeFlow> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypeFlowPostAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CaseTypeFlow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaseTypeFlow>> QuipuGmbHParameterizationStore001CaseTypeFlowPostAsyncWithHttpInfo(CaseTypeFlow body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypeFlow";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeFlowPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseTypeFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseTypeFlow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseTypeFlow)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CaseTypeFlow</returns>
        public CaseTypeFlow QuipuGmbHParameterizationStore001CaseTypeFlowsGet()
        {
            ApiResponse<CaseTypeFlow> localVarResponse = QuipuGmbHParameterizationStore001CaseTypeFlowsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CaseTypeFlow</returns>
        public ApiResponse<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowsGetWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypeFlows";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeFlowsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseTypeFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseTypeFlow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseTypeFlow)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CaseTypeFlow</returns>
        public async System.Threading.Tasks.Task<CaseTypeFlow> QuipuGmbHParameterizationStore001CaseTypeFlowsGetAsync()
        {
            ApiResponse<CaseTypeFlow> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypeFlowsGetAsyncWithHttpInfo();
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CaseTypeFlow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaseTypeFlow>> QuipuGmbHParameterizationStore001CaseTypeFlowsGetAsyncWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypeFlows";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypeFlowsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseTypeFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseTypeFlow)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseTypeFlow)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>CaseType</returns>
        public CaseType QuipuGmbHParameterizationStore001CaseTypePost(CaseType body = null)
        {
            ApiResponse<CaseType> localVarResponse = QuipuGmbHParameterizationStore001CaseTypePostWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of CaseType</returns>
        public ApiResponse<CaseType> QuipuGmbHParameterizationStore001CaseTypePostWithHttpInfo(CaseType body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseType)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of CaseType</returns>
        public async System.Threading.Tasks.Task<CaseType> QuipuGmbHParameterizationStore001CaseTypePostAsync(CaseType body = null)
        {
            ApiResponse<CaseType> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypePostAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (CaseType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CaseType>> QuipuGmbHParameterizationStore001CaseTypePostAsyncWithHttpInfo(CaseType body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CaseType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CaseType)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CaseType)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void QuipuGmbHParameterizationStore001CaseTypePut(CaseType body = null)
        {
            QuipuGmbHParameterizationStore001CaseTypePutWithHttpInfo(body);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> QuipuGmbHParameterizationStore001CaseTypePutWithHttpInfo(CaseType body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypePut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task QuipuGmbHParameterizationStore001CaseTypePutAsync(CaseType body = null)
        {
            await QuipuGmbHParameterizationStore001CaseTypePutAsyncWithHttpInfo(body);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001CaseTypePutAsyncWithHttpInfo(CaseType body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypePut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CaseType&gt;</returns>
        public List<CaseType> QuipuGmbHParameterizationStore001CaseTypesGet()
        {
            ApiResponse<List<CaseType>> localVarResponse = QuipuGmbHParameterizationStore001CaseTypesGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CaseType&gt;</returns>
        public ApiResponse<List<CaseType>> QuipuGmbHParameterizationStore001CaseTypesGetWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CaseType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<CaseType>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CaseType>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CaseType&gt;</returns>
        public async System.Threading.Tasks.Task<List<CaseType>> QuipuGmbHParameterizationStore001CaseTypesGetAsync()
        {
            ApiResponse<List<CaseType>> localVarResponse = await QuipuGmbHParameterizationStore001CaseTypesGetAsyncWithHttpInfo();
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CaseType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CaseType>>> QuipuGmbHParameterizationStore001CaseTypesGetAsyncWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/CaseTypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001CaseTypesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CaseType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<CaseType>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CaseType>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void QuipuGmbHParameterizationStore001PingGet()
        {
            QuipuGmbHParameterizationStore001PingGetWithHttpInfo();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> QuipuGmbHParameterizationStore001PingGetWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/Ping";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001PingGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task QuipuGmbHParameterizationStore001PingGetAsync()
        {
            await QuipuGmbHParameterizationStore001PingGetAsyncWithHttpInfo();

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001PingGetAsyncWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/Ping";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001PingGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ReferenceValue</returns>
        public ReferenceValue QuipuGmbHParameterizationStore001ReferenceValueIdDelete(string id)
        {
            ApiResponse<ReferenceValue> localVarResponse = QuipuGmbHParameterizationStore001ReferenceValueIdDeleteWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ReferenceValue</returns>
        public ApiResponse<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdDeleteWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->QuipuGmbHParameterizationStore001ReferenceValueIdDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValueIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReferenceValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReferenceValue)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReferenceValue)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ReferenceValue</returns>
        public async System.Threading.Tasks.Task<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdDeleteAsync(string id)
        {
            ApiResponse<ReferenceValue> localVarResponse = await QuipuGmbHParameterizationStore001ReferenceValueIdDeleteAsyncWithHttpInfo(id);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ReferenceValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValueIdDeleteAsyncWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->QuipuGmbHParameterizationStore001ReferenceValueIdDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValueIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReferenceValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReferenceValue)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReferenceValue)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ReferenceValue</returns>
        public ReferenceValue QuipuGmbHParameterizationStore001ReferenceValueIdGet(string id)
        {
            ApiResponse<ReferenceValue> localVarResponse = QuipuGmbHParameterizationStore001ReferenceValueIdGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of ReferenceValue</returns>
        public ApiResponse<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdGetWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->QuipuGmbHParameterizationStore001ReferenceValueIdGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValueIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReferenceValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReferenceValue)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReferenceValue)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ReferenceValue</returns>
        public async System.Threading.Tasks.Task<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValueIdGetAsync(string id)
        {
            ApiResponse<ReferenceValue> localVarResponse = await QuipuGmbHParameterizationStore001ReferenceValueIdGetAsyncWithHttpInfo(id);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (ReferenceValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValueIdGetAsyncWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->QuipuGmbHParameterizationStore001ReferenceValueIdGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValueIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReferenceValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReferenceValue)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReferenceValue)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ReferenceValue</returns>
        public ReferenceValue QuipuGmbHParameterizationStore001ReferenceValuePost(ReferenceValue body = null)
        {
            ApiResponse<ReferenceValue> localVarResponse = QuipuGmbHParameterizationStore001ReferenceValuePostWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ReferenceValue</returns>
        public ApiResponse<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValuePostWithHttpInfo(ReferenceValue body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValuePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReferenceValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReferenceValue)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReferenceValue)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ReferenceValue</returns>
        public async System.Threading.Tasks.Task<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValuePostAsync(ReferenceValue body = null)
        {
            ApiResponse<ReferenceValue> localVarResponse = await QuipuGmbHParameterizationStore001ReferenceValuePostAsyncWithHttpInfo(body);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ReferenceValue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValuePostAsyncWithHttpInfo(ReferenceValue body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValuePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReferenceValue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReferenceValue)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReferenceValue)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void QuipuGmbHParameterizationStore001ReferenceValuePut(ReferenceValue body = null)
        {
            QuipuGmbHParameterizationStore001ReferenceValuePutWithHttpInfo(body);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> QuipuGmbHParameterizationStore001ReferenceValuePutWithHttpInfo(ReferenceValue body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValuePut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task QuipuGmbHParameterizationStore001ReferenceValuePutAsync(ReferenceValue body = null)
        {
            await QuipuGmbHParameterizationStore001ReferenceValuePutAsyncWithHttpInfo(body);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001ReferenceValuePutAsyncWithHttpInfo(ReferenceValue body = null)
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValue";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "text/json",
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValuePut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>List&lt;ReferenceValue&gt;</returns>
        public List<ReferenceValue> QuipuGmbHParameterizationStore001ReferenceValuesCodeGet(string code)
        {
            ApiResponse<List<ReferenceValue>> localVarResponse = QuipuGmbHParameterizationStore001ReferenceValuesCodeGetWithHttpInfo(code);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of List&lt;ReferenceValue&gt;</returns>
        public ApiResponse<List<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValuesCodeGetWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001ReferenceValuesCodeGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValues/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValuesCodeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ReferenceValue>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ReferenceValue>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReferenceValue>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of List&lt;ReferenceValue&gt;</returns>
        public async System.Threading.Tasks.Task<List<ReferenceValue>> QuipuGmbHParameterizationStore001ReferenceValuesCodeGetAsync(string code)
        {
            ApiResponse<List<ReferenceValue>> localVarResponse = await QuipuGmbHParameterizationStore001ReferenceValuesCodeGetAsyncWithHttpInfo(code);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (List&lt;ReferenceValue&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ReferenceValue>>> QuipuGmbHParameterizationStore001ReferenceValuesCodeGetAsyncWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001ReferenceValuesCodeGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/ReferenceValues/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001ReferenceValuesCodeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ReferenceValue>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ReferenceValue>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReferenceValue>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>StateMachineDefinitionDto</returns>
        public StateMachineDefinitionDto QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDelete(string code)
        {
            ApiResponse<StateMachineDefinitionDto> localVarResponse = QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteWithHttpInfo(code);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of StateMachineDefinitionDto</returns>
        public ApiResponse<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StateMachineDefinitionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StateMachineDefinitionDto)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateMachineDefinitionDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of StateMachineDefinitionDto</returns>
        public async System.Threading.Tasks.Task<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteAsync(string code)
        {
            ApiResponse<StateMachineDefinitionDto> localVarResponse = await QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteAsyncWithHttpInfo(code);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (StateMachineDefinitionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDeleteAsyncWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDelete");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionCodeDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StateMachineDefinitionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StateMachineDefinitionDto)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateMachineDefinitionDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>StateMachineDefinitionDto</returns>
        public StateMachineDefinitionDto QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGet(string code)
        {
            ApiResponse<StateMachineDefinitionDto> localVarResponse = QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetWithHttpInfo(code);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>ApiResponse of StateMachineDefinitionDto</returns>
        public ApiResponse<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StateMachineDefinitionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StateMachineDefinitionDto)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateMachineDefinitionDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of StateMachineDefinitionDto</returns>
        public async System.Threading.Tasks.Task<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetAsync(string code)
        {
            ApiResponse<StateMachineDefinitionDto> localVarResponse = await QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetAsyncWithHttpInfo(code);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code"></param>
        /// <returns>Task of ApiResponse (StateMachineDefinitionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGetAsyncWithHttpInfo(string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling DefaultApi->QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGet");

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition/{code}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (code != null) localVarPathParams.Add("code", this.Configuration.ApiClient.ParameterToString(code)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionCodeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StateMachineDefinitionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StateMachineDefinitionDto)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateMachineDefinitionDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void QuipuGmbHParameterizationStore001StateMachineDefinitionPost()
        {
            QuipuGmbHParameterizationStore001StateMachineDefinitionPostWithHttpInfo();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> QuipuGmbHParameterizationStore001StateMachineDefinitionPostWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task QuipuGmbHParameterizationStore001StateMachineDefinitionPostAsync()
        {
            await QuipuGmbHParameterizationStore001StateMachineDefinitionPostAsyncWithHttpInfo();

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001StateMachineDefinitionPostAsyncWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void QuipuGmbHParameterizationStore001StateMachineDefinitionPut()
        {
            QuipuGmbHParameterizationStore001StateMachineDefinitionPutWithHttpInfo();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> QuipuGmbHParameterizationStore001StateMachineDefinitionPutWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task QuipuGmbHParameterizationStore001StateMachineDefinitionPutAsync()
        {
            await QuipuGmbHParameterizationStore001StateMachineDefinitionPutAsyncWithHttpInfo();

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> QuipuGmbHParameterizationStore001StateMachineDefinitionPutAsyncWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinition";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;StateMachineDefinitionDto&gt;</returns>
        public List<StateMachineDefinitionDto> QuipuGmbHParameterizationStore001StateMachineDefinitionsGet()
        {
            ApiResponse<List<StateMachineDefinitionDto>> localVarResponse = QuipuGmbHParameterizationStore001StateMachineDefinitionsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;StateMachineDefinitionDto&gt;</returns>
        public ApiResponse<List<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionsGetWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateMachineDefinitionDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<StateMachineDefinitionDto>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateMachineDefinitionDto>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;StateMachineDefinitionDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<StateMachineDefinitionDto>> QuipuGmbHParameterizationStore001StateMachineDefinitionsGetAsync()
        {
            ApiResponse<List<StateMachineDefinitionDto>> localVarResponse = await QuipuGmbHParameterizationStore001StateMachineDefinitionsGetAsyncWithHttpInfo();
            return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ParameterizationStore.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;StateMachineDefinitionDto&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<StateMachineDefinitionDto>>> QuipuGmbHParameterizationStore001StateMachineDefinitionsGetAsyncWithHttpInfo()
        {

            var localVarPath = "/Quipu-GmbH/ParameterizationStore/0.0.1/StateMachineDefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("QuipuGmbHParameterizationStore001StateMachineDefinitionsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<StateMachineDefinitionDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<StateMachineDefinitionDto>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<StateMachineDefinitionDto>)));
        }

    }
}
