// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ShoppingCart.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class ShoppingCart
{
  static readonly string __ServiceName = "ShoppingCart";

  static readonly grpc::Marshaller<global::InsuranceTrialLinkGetRequest> __Marshaller_InsuranceTrialLinkGetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::InsuranceTrialLinkGetRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::InsuranceTrialLinkGetResponse> __Marshaller_InsuranceTrialLinkGetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::InsuranceTrialLinkGetResponse.Parser.ParseFrom);

  static readonly grpc::Method<global::InsuranceTrialLinkGetRequest, global::InsuranceTrialLinkGetResponse> __Method_InsuranceTrialLinkGet = new grpc::Method<global::InsuranceTrialLinkGetRequest, global::InsuranceTrialLinkGetResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "InsuranceTrialLinkGet",
      __Marshaller_InsuranceTrialLinkGetRequest,
      __Marshaller_InsuranceTrialLinkGetResponse);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::ShoppingCartReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of ShoppingCart</summary>
  [grpc::BindServiceMethod(typeof(ShoppingCart), "BindService")]
  public abstract partial class ShoppingCartBase
  {
    /// <summary>
    /// api to generate trial link for 24PW
    /// </summary>
    /// <param name="request">The request received from the client.</param>
    /// <param name="context">The context of the server-side call handler being invoked.</param>
    /// <returns>The response to send back to the client (wrapped by a task).</returns>
    public virtual global::System.Threading.Tasks.Task<global::InsuranceTrialLinkGetResponse> InsuranceTrialLinkGet(global::InsuranceTrialLinkGetRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(ShoppingCartBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_InsuranceTrialLinkGet, serviceImpl.InsuranceTrialLinkGet).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, ShoppingCartBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_InsuranceTrialLinkGet, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::InsuranceTrialLinkGetRequest, global::InsuranceTrialLinkGetResponse>(serviceImpl.InsuranceTrialLinkGet));
  }

}
#endregion
