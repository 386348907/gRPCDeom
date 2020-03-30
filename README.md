# gRPC  Demo

## 此代码为gRPC的服务端   主要为了保存  以备日后使用

### gRPC 介绍:  [简书](https://www.jianshu.com/p/9c947d98e192,'gRPC介绍')


#### 客户端代码放在这:
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
