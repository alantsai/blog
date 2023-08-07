Title: "如何在 Azure Virtual Machines 加上 Public IP"  
Published: 2023-02-13 19:00  
Modified: 2023-02-13 19:00  
Image: "/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230215061753-kj66eu9.png"  
Tags: [ azure, network]  
Series: []  
PostDescription: "在建立 Azure VM 的過程，一般會把 public IP 一起建立起來。不過假設一開始沒建立後面如何在建立出來呢？這篇來一起看一下 Public IP 這個 resource 如何建立和使用"
---

在上一篇 [為什麼我的 Azure Windows Virtual Machine (虛擬機器) 連線不到？故障排除指南指南 | FAQ](/posts/2023/02/faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue) 其中有提到，如果在建立過程把 Public IP 拿掉的話，那麼最後當然就不會建立出來，那麼就只透過內網的 Private IP 來連線

不過建立完之後，想要加載 Public IP Address 會怎麼做呢？

這篇我們來看一下

![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230215061753-kj66eu9.png "建立 Azure VM 會詢問是否建立 Public IP。預設都是會建立"){.img-responsive}
^^^ 建立 Azure VM 會詢問是否建立 Public IP。預設都是會建立

<!--more-->

總共有兩段：

1. 建立 Public IP Address
2. 關聯 Public IP Address

## 建立 Public IP Address

1. 先找到 Public IP Address 的 Service，然後按下 <kbd>Create</kbd>​  
    相對簡單，只要透過搜索就可以找到  
    ​![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230315055225-yqgzffb.png "建立 Public IP Address 對的截圖"){.img-responsive}
    ^^^ 建立 Public IP Address 對的截圖
2. 幾個比較重要的設定有

    ​![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230315055353-xv17dk6.png "建立 Public IP 的設定"){.img-responsive}
    ^^^ 建立 Public IP 的設定

    1. ​`SKU`​ 、`Tier`​ - Public IP Address 可以被掛載在 Load Balancer，所以這邊的 SKU 要配對的上
    2. ​`IP address assignment`​ - IP 要屬於動態 (dynamic) 或者靜態 (static)。動態的意思是隨著資源啟動的時候才會指派 IP，靜態則是不管有沒有啟動都會有一個保留住。

        這個會和費用有關係，動態相對便宜
    3. ​`DNS Name Label`​ - 這個設定截圖大小的關係剛好沒看到。不過假設這邊有設定就可以用 DNS 名稱方式來存取。所以從經濟實惠的角度來說，可以 `IP address assignment`​ 用動態，然後設定 DNS Name Lable 用 DNS 來存取

## 關聯 Public IP Address

找到剛剛建立出來的 Public IP Address，點進去之後：

1. 在 `Overview`​ 畫面的上面，選擇 `Associate`​ 來關聯這個 Public IP

    ​![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230315060956-hyy3qlj.png "Public IP 的 Associate 按鈕"){.img-responsive}  
    ^^^ Public IP 的 Associate 按鈕
2. 在右邊的 `Resource Type`​ 選擇要綁定的類型，然後在從下面對應的下拉選單找到想要綁定的資源。以 VM 為例，綁定到的就是 `Network Interface`​ 就是網卡的部分  
    ​![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230315061114-taiqblo.png "綁定 Public IP 的畫面"){.img-responsive}  
    ^^^ 綁定 Public IP 的畫面

綁定好了之後，我們在去看一下 VM 的 Overview 畫面

1. ​`Public IP address`​ 這邊目前顯示的是資源的名稱。這個是因為建立出來的是動態的 IP，所以只有 VM 跑起來才會有實際的 IP 值。如果今天是靜態的 IP，這邊會直接顯示靜態的 IP
2. ​`DNS name`​ 假設在建立的時候有設定那個 DNS label，這邊就會顯示設定的值。

​![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230315061558-twwo8z9.png "VM 的 Overview 畫面"){.img-responsive}  


假設上面的兩個要調整，直接點下去就會看到：

​![image](/posts/2023/02/2023-02-13-how-to-create-azure-public-ip-and-associate-to-virtual-machinese/image-20230315061939-in4cuhf.png "可以設定 Public IP 的值"){.img-responsive}  
^^^ 可以設定 Public IP 的值

## 結語

這篇我們看了一下如何獨立建立 Public IP Address，並且把它關聯到對應的資源上面

這個也可以看到，微軟在建立資源的時候整合建立的話幫我們把很多事情都一起做掉了，所以如果沒有真的一個一個建立組裝過的話，可能會不知道為什麼是如此

希望大家對於怎麼連到 VM 這個問題都一起解決了。
