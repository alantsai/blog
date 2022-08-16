Title: "[04] Load Balancer (負載平衡) 相關服務 | [挑選適合的 Azure 服務]"  
Published: 2021-04-22 19:00  
Modified: 2021-04-22 19:00  
Image: ""  
Tags: ["「挑選適合的 Azure 服務」", azure,]  
Series: ["「挑選適合的 Azure 服務」", azure]  
PostDescription: "要作出高可用的服務或者想要能夠因應流量來做 scale 的話，那麼 load balancer 就非常重要。選擇什麼 load balancer，用什麼條件進行判斷是我們這篇要探討的問題。"
---
^^^  
​![azure-load-balancer-chose.jpg](/posts/2021/04/2021-04-22-chose-azure-service-04-azure-load-balancer-service/azure-load-balancer-chose-20220330011403-iw2wopx.jpg){.img-responsive}
^^^Load Balancer 相關服務

上雲的其中一個好處是能夠善用它的彈性 (elasticity)，也就是當流量變大的時候，要做 scale out 的時候可以很容易做到。

還有另外一個優點是可以善用跨 region 的好處，讓服務可以部署到不同 region，靠近使用著所在的位置，以及提供 High Availability (HA，高可用）

不管是為了 scale，還是速度或者是 HA，這時候 Load Balancer (負載平衡) 就變得很重要。

那挑選什麼 Load Balancer 也變得很重要，這篇來看一下相關可以使用的服務。
<!--more-->

## 選擇負載平衡的選項

當考慮 Azure Load Balancer 的選項的時候，有兩個點要考慮：

是否需要跨 Region？  
:    需要負載平衡的 workload 是在同一個 region 還是在不同 region？  
    如果跨 region 的話，一般用來建立出高可用的服務，當一個 region 掛了還有另外一個 region 可以使用


是不是 HTTP(S) 相關服務

:    要執行的服務是不是走網路第七層的 HTTP(S) 還是走其他的方式？
    如果是 HTTP(S) 的話還可以提供其他服務，例如 Web Application Firewall (WAF)，也就是可以阻擋常見的攻擊，例如 OWASP Top 10 等。  
    另外一個針對 HTTP(S) 的優勢是可以針對 url path 去做 route。


如果上面兩個問題可以確定的話，那接下來選擇服務就簡單多了：

|服務|是否跨 Region|是否為 HTTP(S)|備註|
| ---------------------| :-------------: | :--------------: | -------------|
|Azure Load Balancer|否|否||
|Application Gateway|否|是|支援 WAF|
|Traffict Manager|是|否|走 DNS 類型|
|Azure Front Door|是|是|支援 WAF|

依照這個概念其實挑選適合的 Load Balancer 就非常容易了，一樣微軟也有做一個判斷表可以用來參考：

^^^  
​![image.png](/posts/2021/04/2021-04-22-chose-azure-service-04-azure-load-balancer-service/image-20220330010138-yx5k244.png){.img-responsive}  
^^^ 應該使用那個 Load Balancer。來源：[https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/load-balancing-overview](https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/load-balancing-overview)

## 結語

在沒有認真了解 Load Balancer 服務之前可能會很難選擇適合的服務。

不過，當把重要的兩個因素抓出來之後，依照情景來選擇就不困難了。

當然，還有很多細節要注意，不過就可以針對性的去在做了解就可以。

## 參考資料

* [Load-balancing options](https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/load-balancing-overview?WT.mc_id=AZ-MVP-5003856)
