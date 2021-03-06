// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class Customer
{
  static readonly string __ServiceName = "Customer";

  static readonly grpc::Marshaller<global::IsProductAddressUpdateAllowedRequest> __Marshaller_IsProductAddressUpdateAllowedRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::IsProductAddressUpdateAllowedRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::IsProductAddressUpdateAllowedResponse> __Marshaller_IsProductAddressUpdateAllowedResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::IsProductAddressUpdateAllowedResponse.Parser.ParseFrom);

  static readonly grpc::Method<global::IsProductAddressUpdateAllowedRequest, global::IsProductAddressUpdateAllowedResponse> __Method_IsProductAddressUpdateAllowed = new grpc::Method<global::IsProductAddressUpdateAllowedRequest, global::IsProductAddressUpdateAllowedResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "IsProductAddressUpdateAllowed",
      __Marshaller_IsProductAddressUpdateAllowedRequest,
      __Marshaller_IsProductAddressUpdateAllowedResponse);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::CustomersReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of Customer</summary>
  [grpc::BindServiceMethod(typeof(Customer), "BindService")]
  public abstract partial class CustomerBase
  {
    public virtual global::System.Threading.Tasks.Task<global::IsProductAddressUpdateAllowedResponse> IsProductAddressUpdateAllowed(global::IsProductAddressUpdateAllowedRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(CustomerBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_IsProductAddressUpdateAllowed, serviceImpl.IsProductAddressUpdateAllowed).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_IsProductAddressUpdateAllowed, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::IsProductAddressUpdateAllowedRequest, global::IsProductAddressUpdateAllowedResponse>(serviceImpl.IsProductAddressUpdateAllowed));
  }

}
#endregion
