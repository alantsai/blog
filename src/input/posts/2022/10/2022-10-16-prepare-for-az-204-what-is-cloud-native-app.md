Title: "Cloud Native App 是什麼？ | AZ-204 在考什麼"  
Published: 2022-10-16 19:00  
Modified: 2022-10-16 19:00  
Image: "/posts/2022/10/2022-10-16-prepare-for-az-204-what-is-cloud-native-app/01-Cloud-Native-Application-是什麼？AZ-204在考什麼-20221017083022-7uu8s6e.jpg"
Tags: [ azure, 「證照」,「ebook」,「AZ-204 在考什麼」]
Series: [「證照」,「ebook」,「AZ-204 在考什麼」]
PostDescription: "作為開發者在找雲端開發相關資料的時候肯定會看到 Cloud Native App  
那什麼是 Cloud Native App 呢？  
了解什麼是 Cloud Native App 會有助於了解 AZ-204 Developing Solutions for Microsoft Azure 到底在考什麼  
因為整個 AZ-204 的目的就是要讓工程師們可以用 Azure 開發出 Cloud Native App  
先來簡單看一下這個概念"

---

^^^  
​![01 Cloud Native Application 是什麼？AZ-204 在考什麼](/posts/2022/10/2022-10-16-prepare-for-az-204-what-is-cloud-native-app/01-Cloud-Native-Application-是什麼？AZ-204在考什麼-20221017083022-7uu8s6e.jpg){.img-responsive}    
^^^ Cloud Native App 是什麼，AZ-204 在考什麼

以前有考過微軟和開發相關證照的人一定會對於像是 70-483 或者 70-486 這種代碼有印象（如果沒看過很好，表示還年輕 XD），那種證照比較專注於實際怎麼開發，但是大家會發現那些現在都 retire 掉了。

而微軟目前和開發比較沾上邊的就只有 AZ-204：Developing Solutions for Microsoft Azure。

而 AZ-204 最主要的講的就是怎麼做出 Cloud Native App。

當大家在搜尋和雲端開發相關知識的時候，相信也常常會看到 ==Cloud Native Application== 或者==雲原生應用==這個名詞。

這個到底指的是什麼？什麼 Application 才算是 Cloud Native App？

這篇我們來簡單看一下這個概念。

<!--more-->

## 回顧一下上雲之路

在進入 Cloud Native App 之前，當然先了解一下什麼是非 Cloud Native App。

這個就讓我想到 2018 在北京曾經有做過一場關於上雲之路的簡報（有興趣可以看看：[2018 北京 Azure bootcamp - Azure Migration 上雲之路](/posts/2018/04/review-stud420180421-beijing-azure-bootcamp-azure-migration)），那時候還只是 Cloud Optimized Application，不過其實離 Cloud Native Application 也沒多遠了。

^^^  
​![image](/posts/2022/10/2022-10-16-prepare-for-az-204-what-is-cloud-native-app/image-20221016172630-nz6xm6k.png "2018 核心概念"){.img-responsive}    
^^^ 2018 簡報核心概念

在當時，主要介紹是前 3 個部分：

1. Existing apps on-prem  - 這個就是沒上雲之前全部都放在地端。那這個的優略相信大家都清楚了
2. Lift and Shift - 純粹把地端的 VM 搬上雲就已經有非常多的優勢，因為可以使用到 IaaS 相關的好處
3. Cloud Optimized - 從 IaaS 轉到 PaaS，在這個過程當中當然應用可能需要做一些調整，也就是所謂的 modernized、refactor 和 rewrite。舉個例子來說，如果應用是 web 並且還在使用 session，那麼雲端的 scale 就沒辦法利用到極致，畢竟一定要導到同一台機器就可能導致資源運用不平均。

其實，Cloud Native App 前面和這個沒什麼兩樣，只是後面的部分也些許不同而已。

回顧完了，4年後，來看一下那現在看到的應該長什麼樣子。

## 什麼是 Cloud Native App？

我們可以先從類似於剛剛看到的圖來看看所謂的 Cloud Native App：

^^^  
​![image](/posts/2022/10/2022-10-16-prepare-for-az-204-what-is-cloud-native-app/image-20221016173619-9zdq6zk.png "Application 的階段。來源：https://learn.microsoft.com/en-us/dotnet/architecture/modernize-with-azure-containers/modernize-existing-apps-to-cloud-optimized/what-about-cloud-native-applications?WT.mc_id=AZ-MVP-5003856"){.img-responsive}    
^^^ Application 的階段。[來源](https://learn.microsoft.com/en-us/dotnet/architecture/modernize-with-azure-containers/modernize-existing-apps-to-cloud-optimized/what-about-cloud-native-applications?WT.mc_id=AZ-MVP-5003856)

前面三個階段大同小異，不過到了 Cloud Native，我們可以看到幾個關鍵字：

1. Microservice Architecture - 微服務架構
2. Architected for the cloud - 需要重新調整程式碼

這幾個實際和技術面有關的部分我們等等展開，不過我們先看一下，什麼是 cloud Native。

### 什麼是 Cloud Native？

[Cloud Native Computing Foundation](https://www.cncf.io/) 提供的[定義](https://github.com/cncf/foundation/blob/main/charter.md)是：

> Cloud-native technologies empower organizations to build and run ==scalable applications== in modern, dynamic environments such as public, private, and hybrid clouds. ==Containers, service meshes, microservices==, ==immutable infrastructure==, and ==declarative APIs== exemplify this approach.
>

> These techniques enable loosely coupled systems that are resilient, manageable, and observable. Combined with robust automation, they allow engineers to make ==high-impact changes frequently and predictably with minimal toil==.
>

簡單來說，Cloud Native 就是 ==speed== 和 ==agility==。既要可以快速反映市場需求，同時面對越來越複雜的商業應用也要能夠快速的回應。

這個時候利用雲端的力量就變得很重要啦。

常看 DevOps 的也會覺得這些描述很熟悉，全部都是有關聯。

如果在展開一些，我們可以看到下圖是微軟總結的幾個支柱：

^^^  
​![image](/posts/2022/10/2022-10-16-prepare-for-az-204-what-is-cloud-native-app/image-20221016180218-kzc47p0.png "Cloud Native 的支柱：[來源](https://learn.microsoft.com/en-us/dotnet/architecture/cloud-native/definition?WT.mc_id=AZ-MVP-5003856)"){.img-responsive}    
^^^ Cloud Native 的支柱：[來源](https://learn.microsoft.com/en-us/dotnet/architecture/cloud-native/definition?WT.mc_id=AZ-MVP-5003856)

由於篇幅的關係，這邊沒辦法每個介紹，但是簡單列一下：

1. Modern Design - 什麼叫做現代化設計呢？簡單來說有人有整理 Twelve-Factor Application 列出了 12個應該要有的設計。不過後續還有持續擴充，所以有時候稱之為 12+ factor。舉個例子來說，API First 就是其中之一，當要走 Microservices 沒有 API 肯定不行。  
    這裡面也有包含什麼算是好的雲端應用的部分，這個環節會是 AZ-304 的範疇，有機會在和大家介紹。
2. Microservices - 既然要有 speed 又要有 agility，那麼所有東西都封裝在一起肯定不行，因此 Microservices 就進來了。這個我們後面展開。
3. Container - 容器化技術的重要性相信大家都知道（如果不知道趕快去惡補一下），也是因為有 Containers 也才讓 Microservices 變得更加容易管理和組合出來。
4. Backing Service - 背後當然需要有些雲服務的支持才有辦法達到使用雲的特性。以 AZ-204 來說當然就是有什麼 Azure 服務可以協助這件事。
5. Automation - 自動化不用說是 DevOps 常在講的一件事。也是透過自動化才能夠快速把系統建立出來，並且可以做到 immutable infrastructure。  
    這個部分會是 AZ-400 的範疇。

## AZ-204 看的是什麼？

在上面的 Cloud Native 的 Pillar 裡面我們可以看到兩個環節是 AZ-204 主要關注的地方：

1. Microservices
2. Backing Service

在精準一點說其實只有 Backing Service，因為 Backing Service 的目的是為了支撐 Microservices。

所以，換句話說 AZ-204 看的更多是在怎麼應用這些 Backing Service。所以並不會介紹怎麼寫 C#、怎麼做架構等這些純開發的事情。

以架構來說（偏 Modern Design），更多是 AZ-305 的職責，純 C# 開發的部分則是沒有相關證照。

大家如果對 Backing Service 的應用不知道從那邊下手，歡迎可以參考一下我在 Tibame 的課程哦：[AZ-204 認證攻略Ｉ從Azure著手雲端開發解決方案](https://www.tibame.com/course/3327)。

## 總結

在這篇，我們簡單看了一下什麼是 Cloud Native App。

以 AZ-204 的角度來說，主要專注的點在於 Azure 有那些服務能夠支撐起這些用途，並且怎麼在程式碼裡面呼叫使用。

在下一篇，我們簡單談一下關於 Microservice，很多的服務都是為了支撐 Microservices 架構的應用。所以我們先簡單介紹一下 Microservice 是什麼，並且要開發 Microservices 會需要什麼？這樣在了解 AZ-204 的內容就會知道為什麼有這些服務。

## 參考資料

1. 免費電子書：[Architecting Cloud Native .NET Applications for Azure](https://dotnet.microsoft.com/download/e-book/cloud-native-azure/pdf?WT.mc_id=AZ-MVP-5003856)
2. 免費電子書：[Modernize existing .NET applications with Azure cloud and Windows Containers](https://learn.microsoft.com/en-us/dotnet/architecture/modernize-with-azure-containers/?WT.mc_id=AZ-MVP-5003856)
3. 微軟參考資料：[Introduction to cloud-native applications](https://learn.microsoft.com/en-us/dotnet/architecture/cloud-native/introduction?WT.mc_id=AZ-MVP-5003856)