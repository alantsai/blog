Title: "Azure Savings Plan 和 Azure Reservation (Reserved Instances) 傻傻分不清楚"  
Published: 2023-03-07 19:00  
Modified: 2023-03-07 19:00  
Image: "/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/cover.jpg"  
Tags: [ faq, azure, cost]  
Series: []  
PostDescription: "這篇文章主要在講述 Azure 的兩種付費方案：Azure Reserved Instances（RI）和 Azure Savings Plans（SP），以及它們之間的差異與使用時機。
在引進任何服務或軟體之前，評估其成本與效益是說服老闆的最關鍵一步。在 Azure 的世界裡，RI 是一種預先購買特定機器規格的付費方案，可以讓你省下最多 72% 的運算費用。不過，由於 RI 較為僵化，使用時需要特別注意其限制。SP 則相對較新，旨在提供一個介於 RI 和一般 PAYG 方案之間的選擇，更具彈性。
本文將會簡單介紹這兩種方案之間的差異，以及在什麼情況下適合使用哪一種方案。"

---
​![圖片來源：https://pixabay.com/en/despair-alone-being-alone-archetype-513528/](/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/cover.jpg){.img-responsive} 
^^^ 圖片來源：https://pixabay.com/en/despair-alone-being-alone-archetype-513528/

要導入任何服務或者軟體之前，評估它的成本 (費用) 以及效益是說服老闆的最關鍵的一件事。

以 Azure 來說，以前有所謂的 Azure Reservation (Reserved Instance) 可以省到 62% 之多，所以如果有穩定使用的機器規格，不開 Reserved Instance 說不過去。

既然有了它，怎麼還會有另外一個所謂 Savings Plan 呢？

這篇來簡單的探討一下兩個的不同之處，以及什麼時候適合用什麼
<!--more-->
## TL;DR

||Azure Reserved Instances|Azure Savings Plans|
| ------------------------------------| -------------------------------------| -------------------------------------------------------------------------------------|
|概觀|預先購買某些機器規格|預先購買特定使用量|
|適用服務|VMs、SQL databases、Cosmos DB、etc.|VMs、 dedicated host、 Container Instance、App Service、 Azure<br />Premium Functions<br />|
|付款方式|一次性付款、部分預付款或按月付款|一次性付款或按月付款|
|持續時間|1 或 3 年|1 或 3 年|
|靈活度|指定規格大小和 region|彈性的使用時數和 region|
|優惠力度|可以到 72%|可以到 65%|
|*折扣只有運算，不包括 License 費用|||

## 什麼是 Azure Reservation (Reserved Instance)

雲的特性之一是彈性，但是當服務穩定之後，其實不太需要這個彈性度

如果可以把這個彈性度換成運算更加便宜，那麼是不是會更好？

所以，Azure Reservation 的意思是，先提前==買好資源==，因此可以==有些優惠==

不是所有都可以提前買好，不過因為最常看到會買的都是 VM 的資源，而在 VM 叫做 Reserved Instance 因此有時候直接稱之為 Reserved Instance

​![Azure Reservation 可以購買的資源](/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/image-20230306190318-ihww5pm.png "Azure Reservation 可以購買的資源"){.img-responsive} 
^^^ Azure Reservation 可以購買的資源

以下都已 VM 的描述為主（也就是 Reserved Instance 或者 RI）：

1. 可以買 1~3 年 - 可以提前付或者每個月付。可以節省 41% ~ 62% 的==運算費用==。（不涵蓋 License。License 可以搭配 Azure Hybrid Benefit）
2. 適用的機型會受到當初購買的限制規格。調整規格只能夠==有限度的==在 [instance size flexibility group](https://learn.microsoft.com/en-us/azure/virtual-machines/reserved-vm-instance-size-flexibility?toc=%2Fazure%2Fcost-management-billing%2Freservations%2Ftoc.json&WT.mc_id=AZ-MVP-5003856) 或 [capacity priority](https://learn.microsoft.com/azure/cost-management-billing/reservations/manage-reserved-vm-instance?WT.mc_id=AZ-MVP-5003856#change-optimize-setting-for-reserved-vm-instances) (單個 scope)。
3. 一般來說 RI 會比 Saving Plans

RI 最大的問題就在於彈性不是很大。RI 的概念是買某個機器規格，因此只能夠適用於某個機器規格（或者有限度的那個系列）

所以，有沒有可能可以給出一個像是 RI 但是又不會被機器規格綁死的東西？

## 什麼是 Azure Savings Plans

這個服務算是相對新，在 2022 年的 10 月 GA

最主要的目的就是希望可以在 RI 以及一般的牌價（PAYG）中間取得一個平衡點

我們說 RI 的問題在於不夠彈性，這個正是 Savings Plans（SP） 想要解決的點

簡單來說，SP 買的是==時數==，而不是像 RI 買的是某個機器規格

所以，如果確定會用到某個時數（量），但是不一定是某個機器規格或者某個 region，那麼只要在提前購買的時數內，就可以得到優惠

這個時候，到底要買多少就變得很重要，下圖是官方介紹這個功能：

​![官方介紹圖](/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/image-20230308063507-6ejjae0.png){.img-responsive} 
^^^ 官方介紹圖 - [來源](https://azure.microsoft.com/en-us/pricing/offers/savings-plan-compute/?WT.mc_id=AZ-MVP-5003856#benefits-and-features)

如果今天要購買，很容易只需要查 `Savings Plans`​ 就可以看到：

​![購買 Savings Plans 的畫面](/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/image-20230308061554-dxbyfv4.png "購買 Savings Plans 的畫面"){.img-responsive} 
^^^ 購買 Savings Plans 的畫面

## 當 RI 和 SP 都有的時候，套用的順序是：

1. RI 的優先度會比 SP 高
2. 如果有多個 SP 就會是最便宜的被套用

## 費用比較

下圖是從：[Quick Reference: Understanding Azure Reservations vs Savings Plans](https://techcommunity.microsoft.com/t5/core-infrastructure-and-security/quick-reference-understanding-azure-reservations-vs-savings/ba-p/3689070?WT.mc_id=AZ-MVP-5003856) 截圖出來的比較表，裡面的金額不一定和現在一樣，不過這個只是給大家看出這個比較。

​![PAYG、SP、RI 的費用比較](/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/image-20230308061912-p3m6oo6.png "PAYG、SP、RI 的費用比較"){.img-responsive} 
^^^ PAYG、SP、RI 的費用比較

如果在計算的時候需要確認金額，記得要選對選項：

​![Azure Pricing Calculator 的費用](/posts/2023/03/2023-03-07-faq-difference-between-azure-savings-plans-and-azure-reserved-instances/image-20230308062104-x2f5vc4.png "Azure Pricing Calculator 的費用"){.img-responsive} 
^^^ Azure Pricing Calculator 的費用

## 結語

在彈性和費用之間取得一個平衡是使用雲服務的一個很重要一件事

希望透過這篇，大家對於 Savings Plan 和 Reserved Instance 的差異有所了解，並且可以省到錢

## 參考資料

1. [Quick Reference: Understanding Azure Reservations vs Savings Plans](https://techcommunity.microsoft.com/t5/core-infrastructure-and-security/quick-reference-understanding-azure-reservations-vs-savings/ba-p/3689070?WT.mc_id=AZ-MVP-5003856)
2. [What is Azure savings plans for compute?](https://learn.microsoft.com/azure/cost-management-billing/savings-plan/savings-plan-compute-overview?WT.mc_id=AZ-MVP-5003856)
