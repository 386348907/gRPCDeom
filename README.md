# gRPC  Demo

## 此代码为gRPC的服务端   主要为了保存  以备日后使用

### gRPC 介绍:  [简书](https://www.jianshu.com/p/9c947d98e192)
 
## 添加引用
```
### 客户端
 + Grpc.Tools
 + Grpc.Net.Client
 + Google.Protobuf
### 服务端
 + Grpc.AspNetCore
 ```
 

### 使用步骤 1 定义消息

```
syntax="proto3";

package FirstServer.Message;

//指定命名空间
option csharp_namespace="FirstServer.Message";
 
 //定义消息主体
message  HandleMarkData{

string SCZSBH=1;

}

//定义返回值
message  HandleMarkDataRequest{
int32 status=1;
string msh=2;
string data=3;
string r1=4;
string r2=5;
}

//定义服务
service HandleMarkDataService{

//gRPC服务分为 
//1 简单rpc   这就是一般的rpc调用，一个请求对象对应一个返回对象
//2 服务端流式rpc   一个请求对象，服务端可以传回多个结果对象
//3 客户端流式rpc   客户端传入多个请求对象，服务端返回一个响应结果
//4 双向流式rpc   结合客户端流式rpc和服务端流式rpc，可以传入多个对象，返回多个响应对象


//简单rpc
rpc HandleMD(HandleMarkData) returns (HandleMarkDataRequest);

}
```

### 使用步骤2 编写服务端代码  直接看源码

### 使用步骤3 定义客户端代码
```
      //创建管道
     var channel = GrpcChannel.ForAddress(" https://localhost:5001");
      //创建链接
     var client = new HandleMarkDataService.HandleMarkDataServiceClient(channel);
      //发起请求
     var rap= await client.HandleMDAsync(new HandleMarkData
            {
                SCZSBH = "1323"
            });
      //读取返回值
     Console.WriteLine($"xxxxxxxxx{rap}");
```




###  完了 end

