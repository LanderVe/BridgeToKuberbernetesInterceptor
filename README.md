# BridgeToKubernetes Interceptor

This is the sample application for [this blog](https://blogs.u2u.be/lander/post/2020/11/25/properly-propagating-kubernetes-route-as-in-bridge-to-kubernetes).

## Usage

Open in Visual Studio and run the application. Use [Postman](https://www.getpostman.com) or similar tool to send a message like:

```
GET  HTTP/1.1
Host: localhost:44341
kubernetes-route-as: pepito
User-Agent: PostmanRuntime/7.16.3
Accept: */*
Cache-Control: no-cache
Postman-Token: 1f9566c5-18f3-408a-bc02-dcd9870cb225,c201f141-46c7-4126-ba3c-f0259fed721a
Accept-Encoding: gzip, deflate
Connection: keep-alive
cache-control: no-cache
```

You should see the "kubernetes-route-as" in the resulting HTML.