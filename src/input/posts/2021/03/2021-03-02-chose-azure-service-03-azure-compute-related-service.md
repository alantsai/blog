Title: "[03] 運算相關服務 | [挑選適合的 Azure 服務]"  
Published: 2021-03-02 19:00  
Modified: 2021-02-02 19:00  
Image: "/posts/2021/03/2021-03-02-chose-azure-service-03-azure-compute-related-service/20220329233317-l5g14h6.jpg"  
Tags: ["「挑選適合的 Azure 服務」", azure,]  
Series: ["「挑選適合的 Azure 服務」", azure]  
PostDescription: "任何應用程式都需要運算 (Compute) 相關的服務。那怎麼挑選適合的 Azure Compute 服務呢？這篇我們來看一下有什麼服務可以使用"
---

^^^  
​![03 運算相關服務.jpg](/posts/2021/03/2021-03-02-chose-azure-service-03-azure-compute-related-service/20220329233317-l5g14h6.jpg){.img-responsive}  
^^^Azure 運算相關服務

當思考假設任何應用程式的時候，第一個要思考的肯定是運算相關的服務。  
也就是要使用什麼方式來執行應用程式。

這個時候取決於幾個不同的考量點，可能會使用不同的服務。

這篇，來看一下，那些需要思考的點，以及可以參考的地方。

<!--more-->

## 選擇運算服務的決策樹

我們可以先來看一下微軟所提供的的提供給我們判斷的決策樹：

^^^  
​![image.png](/posts/2021/03/2021-03-02-chose-azure-service-03-azure-compute-related-service/image-20220329213851-82vgpkb.png){.img-responsive} 
^^^微軟提供的和運算相關的決策樹：[https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/compute-decision-tree](https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/compute-decision-tree?WT.mc_id=AZ-MVP-5003856)

這個樹其實非常完整的涵蓋了幾種不同的情景。  
我們可以針對幾個情景做一點說明：

* 要用 IaaS 還是 PaaS？
* 要用 Container 嗎？
* 事件類型的運算嗎？
* 批次類型的處理嗎？

## 要用 IaaS 還是 PaaS？

IaaS 以及 PaaS 的差異相信不需要贅述。

IaaS 不用說，基本上只有 Virtual Machine 可以選擇。如果需要可以做 Scale out，那麼就可以考慮 Virtual Machine Scale Set。  
所以，如果需要能夠完整掌控機器的話，那就只能夠考慮 IaaS。

至於 PaaS 的話，基本上剩下的服務大部分都屬於 PaaS。  
取決於執行的服務類型，如果是 Web 相關應用，那麼以 App Service 為主。  
其他類型則可以參考下面。

## 要用 Container 嗎？

Container 的好處相信這幾年大家也有非常多的了解。

因此把服務打包成為 Container 已經變成了一個很常見的情景。

如果今天要執行的是 Container 相關，那有以下幾個可以做參考：

Azure App Service  
:    app service 也可以執行 Container。  
    如果說是一個不需要 Orchestrator 的情況下，並且是一個需要==持續執行==的服務，那麼 app service 滿適合。


Azure Container Instance (ACI)  
:    如果今天執行的是類似於==一下開一下關==的情況，並且也不需要 Orchestrator，那麼這個服務很適合。


Azure Kubernetes Service (AKS)  
:    不用說，如果需要 Orchestrator 的話，那麼 K8S 已經是標準。因此使用它的 PaaS 服務 AKS 很適合。

## 事件類型的運算嗎？

這邊提到的事件 (Event) 主要是針對某個事情發生的時候要觸發並且要執行某些程式的情況下很適合。

舉例來說，為了可以避免元件之間的耦合度，一般都會考慮墊一層 queue。  
那這個時候，queue 加了一筆資料的時候，會希望觸發對應的事情進行處理，就是我們這邊提到的事件。

這個時候，Azure Function 就非常適合。因為 Azure Function 可以透過 Binding 的概念，只需要設定一下，然後就可以把資料透過 parameter 的方式把資料直接拿到，不需要花其他工在和服務之間進行溝通，而只需要 focus 在處理這段資料的邏輯上面就好。

更多資料可以參考：

* [Azure Functions triggers and bindings concepts](https://docs.microsoft.com/en-us/azure/azure-functions/functions-triggers-bindings?tabs=csharp&WT.mc_id=AZ-MVP-5003856)

## 批次類型的處理嗎？

如果今天要執行的是 High Performance Compute (HPC) 或者是一些需要大量運算的話，那麼可以考慮使用 Azure Batch。

範例可能是做像是媒體轉碼，或者是 ETL 作業。

^^^  
​![image.png](/posts/2021/03/2021-03-02-chose-azure-service-03-azure-compute-related-service/image-20220329231407-9pbpct3.png){.img-responsive}  
^^^運作方式。來源：[https://docs.microsoft.com/en-us/azure/batch/batch-technical-overview](https://docs.microsoft.com/en-us/azure/batch/batch-technical-overview?WT.mc_id=AZ-MVP-5003856)

Azure Batch 簡單來說可以分成兩個部分：

1. 把需要執行的東西放在 Azure Storage
2. 實際執行的作業是透過 Job 以及裡面的 Pool 最後結果回傳到 Storage

## 結語

這篇簡單的使用了微軟提供的判斷樹來說明幾個常見的運算相關服務。  
希望透過這篇在挑選不同的運算服務的時候，有個比較清晰的概念。