Title: "如何避免 Azure 服務中斷 - 從 2月的當機事件來看看基本的高可用概念"  
Published: 2023-02-16 19:00  
Modified: 2023-02-16 19:00  
Image: "/posts/2023/02/2023-02-16-understand-azure-reliability-and-availability-lesson-learned-from-azure-Incident/image-20230312173737-m714i4p.png"  
Tags: [ azure, reliability]  
Series: []  
PostDescription: "Azure 的 Availability 是要用 Azure 就需要懂得基本概念。這篇透過 Azure 在 2月遇到的事件，來看看高可用的概念"

---

在今年的 02/07 到 02/09 號之間，在 Southeast Asia 和 East Asia 這兩個 region 的服務都有受到影響，甚至導致資源無法存取

剛好藉著這個事件，我們這篇來探討一下在 Azure 裡面最基本的高可用（High Availability）概念，也就是 Regional、Availability Zone 和 Availability Set

取決於應用的等級，應該用什麼等級的高可用，這篇我們來看一下



## TL;DR;

|功能|Azure Region|Availability Zone|Availability Set|
| ---------------------| --------------------------------------------------| -------------------------------------------------| ------------------------------------------------|
|定義|包含一個或多個資料中心的地理區域|擁有獨立電力和網路的單一資料中心|在資料中心內的虛擬機器的邏輯分組|
|目的|- 能夠部署應用在更靠近使用者的地方<br />- 提供高可用|提供更高的高可用|提供高可用|
|SLA|保證 99.99% 的運行時間|每個 Zone 保證 99.99% 的運行時間|每個 Set 保證99.95% 的運行時間|
|隔離|與其他 Region 隔離，擁有獨立資源|與其他 Zone 隔離，擁有獨立資源|多台 VM 橫跨在多個 Fault Domain|
|費用|價格因 Region 而異|除 VM 和儲存空間外，無額外費用|除 VM 和儲存空間外，無額外費用|
|VN11-JD8 事件的影響|East Asia Region 的部分服務受到影響|如果有部署到 2 個或以上 Zone 的服務受到服務影響|部署到有影響的 Datacenter 應用因此受到服務中斷|

<!--more-->

## 發生了什麼事？追蹤 Id：VN11-JD8

完整的事件報告可以在這邊看到：[Azure status history](https://azure.status.microsoft/en-us/status/history?WT.mc_id=AZ-MVP-5003856)

整個事件的時間：2023/02/07 20:19 ~ 2023/03/09 04:30

簡單來說，就是在 Southeast Asia 的 Region 其中一個 Availability Zone 發生了冷卻系統異常，導致了：

1. 整個 Datacenter 為了保護基礎建設和資料因此整個關閉

並且有兩個==沒有預期==的錯誤也發生了：

1. 有些跨 region 的服務因此受到影響（degradation）
2. 有些設計在出錯的時候 failover 到跨 zone 或者跨 region 的服務沒有運作正常

那些服務受到那些影響，以及完整的過程可以參考上面提供的連結，這邊以這個事件為例目的只是讓大家知道，機器總是有可能壞掉，所以規劃好高可用的策略很重要

## 基本的高可用 (High Availability) 概念

以 Azure 來說，我們可以簡單分為 3 個層級：

1. Regional
2. Availability Zone
3. Availability Set

這三個層級，在 Azure 的不同服務有不同的設定方式可以達到，這篇將會以 Azure Virtual Machine （VM） 作為範例

### Regional

當我們建立任何的 Azure 資源的時候，第一個碰到的選擇都會是建立在哪裡，而這個哪裡就是 Regional

離我們亞洲最近的就是 East Asia（香港）以及 Southeast Asia（新加坡）

以我們這次的案例，就是發生在 Southeast Asia 這個 Region

​![在 Azure Portal 建立 VM 的畫面](/posts/2023/02/2023-02-16-understand-azure-reliability-and-availability-lesson-learned-from-azure-Incident/image-20230312172512-a3j5wlv.png "在 Azure Portal 建立 VM 的畫面"){.img-responsive}  
^^^ 在 Azure Portal 建立 VM 的畫面

如果是 Regional 等級的高可用，同等於在 2 個或以上的 Region 裡面要建立出一樣的 VM 然後在透過像是 [Azure Traffic Manager](https://learn.microsoft.com/azure/traffic-manager/traffic-manager-overview?WT.mc_id=AZ-MVP-5003856){.img-responsive} 或者 [Azure Front Door](https://learn.microsoft.com/azure/frontdoor/front-door-overview?WT.mc_id=AZ-MVP-5003856){.img-responsive} 來把流量導向正確的地方

這邊有很多資訊簡化掉了，如果想要結費，還可以在區分出到底是建立 Active-Active 還是 Active-StandBy 等模式

以這次案例來說，如果有做到 Regional 的高可用，那麼可以避免受到這次事件導致服務中斷

Secondary Region 的概念沒有提到，所以這次為例雖然發生的問題在 Southeast Asia，但是 East Asia 也受到了影響

### Availability Zone

不是所有的 Region 都有支援 Availability Zone，如果有，就至少會有 3 個 Zone

1 個 Zone 裡面就有 ==1 個或者多個 Datacenter==

Datacenter 之間的水、電是分離

​![官方介紹 Availability Zone](/posts/2023/02/2023-02-16-understand-azure-reliability-and-availability-lesson-learned-from-azure-Incident/image-20230312173737-m714i4p.png "官方介紹 Availability Zone"){.img-responsive}
^^^ 官方介紹 Availability Zone

Azure 什麼服務有支援到 Zone，以及支援到什麼程度可以參考這個[連接](https://learn.microsoft.com/en-us/azure/reliability/availability-zones-service-support?WT.mc_id=AZ-MVP-5003856)

Azure VM 在建立的過程，如果想要設定，那麼就可以從 Zone 裡面去選擇

​![Azure VM 建立 Zone 的截圖](/posts/2023/02/2023-02-16-understand-azure-reliability-and-availability-lesson-learned-from-azure-Incident/image-20230312174549-jxp36vj.png "Azure VM 建立 Zone 的截圖"){.img-responsive}  
^^^ Azure VM 建立 Zone 的截圖

如果有建立兩個或以上的 VM 在不同的 Zone，可以保證至少 1 個 VM 的連線可以在 99.99%

以這個事件來說，如果有部署在 Availability Zone 上，因為水電等是分開的，所以可以避免受到服務中斷

### Availability Set

由於機器有可能會有物理上的==非預期損壞導==致服務中斷，以及==有預期的更新==導致服務中斷，為了解決這兩種情況有所謂的 Availability Set

Availability Set 就是 Datacenter 裡面的機櫃，每一組的 Availability Set 就可以確保部署的機器放在==不同的機櫃==上面

透過這個方式，可以確保例如在做有預期更新的時候，可以分開做，導致不會兩台機器一起被關機

Availability Set 的兩個 domain 就是為了代表不同的意圖把 VM 放到不同的機櫃上面：

1. Fault Domain - 非預期損壞的一群
2. Update domain - 有預期更新的一群

以 Azure VM 的 SLA 來說，2 台或以上的 VM 部署在==同一個== Availability Set 可以達到 99.95% 的 SLA

​![Azure VM 的 Availability Set](/posts/2023/02/2023-02-16-understand-azure-reliability-and-availability-lesson-learned-from-azure-Incident/image-20230312180245-jggeq9p.png "Azure VM 的 Availability Set"){.img-responsive}
^^^ Azure VM 的 Availability Set

‍
