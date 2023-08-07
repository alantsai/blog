Title: "使用 Azure VM Comparison 來找出類似規格的 VM"
Published: 2023-01-13 19:00
Modified: 2023-01-13 19:00
Image: ""
Tags: [ azure, tool]
Series: []
PostDescription: "假設今天已經有了某個規格，怎麼知道它會不會比 XYZ 來的好呢？今天透過 Azure VM Comparison 這個工具讓我們做這件事簡單"

---

在 [上一篇](/posts/2023/01/azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector) 我們看了如何從需求的角度來找出適合的 VM 規格

不過假設今天是要反過來呢？

也就是假設已經有用了某個規格，想要知道有沒有更好的規格那怎麼辦呢？

今天介紹的 Azure VM Comparision 就是要解決這個問題

來看看怎麼使用

<!--more-->

## 什麼是 Azure VM Comparison？怎麼使用

可以從這個網址去存取：

[https://azureprice.net/](https://azureprice.net/)

會看到下面這個截圖的內容：

​![image](/posts/2023/01/2023-01-13-azure-tool-how-to-find-better-vm-sku-using-azure-vm-comparison/image-20230317155542-g4w352m.png "Azure VM Comparison 的主頁"){.img-responsive}  
^^^ Azure VM Comparison 的主頁

1. 可以選擇要看到的幣別
2. 要看到的主要 Region
3. 金額計算方式。小時、天、月、年
4. 什麼模式的 VM。一般的還是 spot instance
5. 什麼的價格。牌價，還是 RI 1 年還是 RI 3年
6. VM 規格的名稱，當滑動上去的時候，會有個小的 tooltip 顯示每個數字的含義，以及一些重要資訊例如什麼時候 retire
7. 如果想看看有沒有同類型的規格但是更便宜，可以選 `find better`​
8. 如果想要知道這個規格在那個 Region 最便宜，可以選 `compare`​
9. 如果想要比對規格，可以在規格的左邊 checkbox 點一下，就可以加入比對操作

## 假設有人推薦 B4ms 比較好，應該如何評估？

延續和上一篇一樣的情境，需要的規格是：

1. Windows Server 2022
2. SQL Server Enterprise 2022
3. 16 GB 記憶
4. 4 CPU

使用 Azure Virtual Machine Selector 推薦的是：`D4as_v5`​

這個時候你的同事說，有個更好的規格叫做 `B4ms`​，請問如何比較是否真的比較好？

我們用 Azure VM Comparison 來看看怎麼比較：

1. ​![image](/posts/2023/01/2023-01-13-azure-tool-how-to-find-better-vm-sku-using-azure-vm-comparison/image-20230317160726-64pss6x.png "在輸入框輸入 `D4as_v5`，找到規格把它勾選起來"){.img-responsive}  
    ^^^ 在輸入框輸入 `D4as_v5`​，找到規格把它勾選起來
2. ​![image](/posts/2023/01/2023-01-13-azure-tool-how-to-find-better-vm-sku-using-azure-vm-comparison/image-20230317160823-hwntwc5.png "把輸入框內容改成 `b4ms` 然後把它勾起來，這個時候可以點下 Compare 按鈕"){.img-responsive}  
    ^^^ 把輸入框內容改成 `b4ms`​ 然後把它勾起來，這個時候可以點下 Compare 按鈕
3. 可以看到兩個規格的比較表

    [https://azureprice.net/compare?vms=Standard_D4as_v5,Standard_B4ms](https://azureprice.net/compare?vms=Standard_D4as_v5,Standard_B4ms)

我們來抓一下幾個可以注意的點：

​![image](/posts/2023/01/2023-01-13-azure-tool-how-to-find-better-vm-sku-using-azure-vm-comparison/image-20230318115805-4xxyuxn.png "比對畫面的詳細資訊"){.img-responsive}  
^^^ 比對畫面的詳細資訊

1. 首先可以看到 VM 的每個字母的含義。這邊要注意的是 B 代表的是 `Economical burstable`​ 這個含義我們稍等說
2. ​`Performance Score`​ 雖然 CPU 規格一樣，但是因為硬體用的不同，所以實際的效能可能不同。如果熟悉 Azure VM 就知道 ACU 這個單位，而 Performance Score 則是更進一步，用工具壓測出來的數字結果。  
    以這個範例可以看到 D4as_V5 比較好一點
3. ​`Avg Price Diff`​ 這個則是從費用的角度看看那個比較貴。以這個為例 D4as_V5 會比較貴一點

回到一下 `Economical burstable`​ 這件事，如果去查官網 B 系列機器的介紹：

[B-series burstable virtual machine sizes](https://learn.microsoft.com/en-us/azure/virtual-machines/sizes-b-series-burstable?WT.mc_id=AZ-MVP-5003856)

​![image](/posts/2023/01/2023-01-13-azure-tool-how-to-find-better-vm-sku-using-azure-vm-comparison/image-20230318121938-sy2f4lt.png "引述一段關於 Burstable 的含義"){.img-responsive}​

由此可以看出，如果假設今天需要的是持續性的 CPU 運算，那麼 B 系列就會不適合

### 如果今天已經用了某個規格，怎麼知道還有那些其他也適合？

除了上面提到的那種方式來查類似規格，還有一個是看某一個規格的詳細頁。

譬如說：[Standard_B4ms](https://azureprice.net/vm/Standard_B4ms)

下面會有個 `Similar alternative VMs`​ 也可以從這邊看到類似規格以及效能的部分：

​![image](/posts/2023/01/2023-01-13-azure-tool-how-to-find-better-vm-sku-using-azure-vm-comparison/image-20230318123201-t1zu5kw.png "Similar alternative VMs 的畫面部分"){.img-responsive}​

這個也可以在條例頁的時候，點 `find better`​ 來呼叫出一樣的內容

## 結語

透過 Azure VM Comparison 這個工具，相信對於要怎麼比對規格有個更好的確認方式。

所以當 Azure VM Selector 和 Azure VM Comparison 結合起來的時候，就會是一個從需求面，一個從規格面來找到最適合需求的 VM。

以上就是這兩個工具的介紹，如果大家有更好的做法也歡迎和我分享哦
