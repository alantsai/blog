Title: "為什麼我的 Azure Windows Virtual Machine (虛擬機器) 連線不到？故障排除指南指南 | FAQ"  
Published: 2023-02-11 19:00  
Modified: 2023-02-11 19:00  
Image: ""  
Tags: [ azure, faq]  
Series: []  
PostDescription: "建立 Virtual Machine (虛擬機器) 算是第一次結果雲端的 Hello World。但是，建立是建立出來了，如果沒有辦法連線進去是一件很挫折的事情。  
而連線進去有可能是很多個因素導致，所以怎麼排查問題就變得很重要。

這邊我們來看一下，當真的遇到這個問題要怎麼解決。"

---

對於任何第一次上手任何雲端服務的時候，第一件事估計都是建立出 Virtual Machine (虛擬機器)，算是雲端的 Hello World 吧。

這個時候，如果遇到無法連線（這邊的連線指的是透過 Remote Desktop Protocol）進去估計會很沮喪，導致撞墻不想繼續下去。

^^^  
​![到底為什麼連不到](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215063151-0cpnx3h.png "到底為什麼連不到"){.img-responsive}  
^^^到底為什麼連不到

我這篇想要先介紹一下，如果遇到這件事，可以從什麼角度去嘗試排除問題。

這邊主要是會以 Azure 的 Windows VM，不過基本概念在任何雲端平台都是一樣的概念。

<!--more-->

## 排除的步驟

大概可以分幾個部分：

1. 確認一下建立的 VM 是否有賦予他對外連線的相關資源
2. 確認一下是不是有因為防火墻導致阻擋了連線
3. 確認一下是不是你的網路環境導致連線不進去
4. 確認一下是不是因為忘記了帳號密碼所以導致連不進去

### 確認一下建立的 VM 是否有賦予他對外連線的相關資源

如果我們今天想要連到 VM，但是沒有給他讓我們可以定位的點，那麼肯定連線不進去。

這就像是，如果你想要去拜訪朋友，你總要有朋友的==地址==。

地址對應到地圖就會有精準的==經緯度==，這樣導航才可以正確的帶我們過去。

這兩個資訊，理論上我們只要有其中一個，就可以準確的到達目的地。

對應到資訊系統：

1. 地址 = Domain
2. 經緯度 = IP

    :::{.bs-callout .bs-callout-info}
    準確一點說，IP 又有區分 Private IP 和 Public IP  
    Private IP 代表要在同個網路才能夠識別（類似於雅房的概念，同一間屋子才能夠識別），基本上以下 3 個就是 Private IP:  
    1.10.0.0.0/8  
    2.172.16.0.0/12  
    3.192.168.0.0/16  
    Public IP 則是從外部網路可以識別（類似於有門牌的套房的概念）
    :::

所以，第一件事就要先確認到底你的虛擬機器是否有這兩個資訊的其中一個？

我們可以從 Azure VM 的 Overview 來看到這件事：

^^^  
​![Azure VM 的 Overview 內容](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215062259-ishnlzv.png "Azure VM 的 Overview 內容"){.img-responsive}  
^^^Azure VM 的 Overview 內容

從上圖的兩個地方：

1. ​`Public IP Address`​ - 這邊的地址就是我們指派給她的 Public IP
2. ​`DNS Name`​ - 假設今天不想要建立 Public IP（雖然 IP 不算貴，但是想省錢的話），那麼透過設定 DNS Name 也可以達到能夠連線的地方

我們點 `Connect`​ 的時候，也會問到底是用什麼方式連線來提供連線資訊：

^^^  
​![Connect 的不同選擇方式](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215062802-kxpsux1.png "Connect 的不同選擇方式"){.img-responsive}  
^^^Connect 的不同選擇方式

假設，只有看到 `Private IP address`​，那麼除非你的網路環境和機器在同個網路環境（例如有 VPN 進入 Azure）那麼是不可能透過 Private IP address 連線進去。

至於怎麼建立出 Public IP 或者 DNS 我另外一篇介紹

這步做完之後，至少會拿到 Public IP 或者 DNS

### 確認一下是不是有因為防火墻導致阻擋了連線

接下來連不連的進去取決於有沒有阻擋。

那這個有幾個部分：

1. 在 Azure 上面的 Network Security Group (NSG) 有沒有允許連線？
2. 你的機器內部防火墻是否擋住了這件事？

#### 在 Azure 上面的 Network Security Group (NSG) 有沒有允許連線？

這個在 Azure 上面很好檢查，我們可以透過：

Virtual Machine => Newtorking 去檢查

^^^  
​![Azure VM 上面的 Networking 畫面](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215063549-4907mjz.png "Azure VM 上面的 Networking 畫面"){.img-responsive}  
^^^Azure VM 上面的 Networking 畫面

1. 先確認我們規則的 `Priority`​ 順序。`數字越小，優先級越高`​
2. 確認開的 `Port`​ 對不對，以我們要 RDP 的例子，需要開 3389
3. 確認好 `Action`​ 是 `Allow`​

#### 你的機器內部防火墻是否擋住了這件事？

就和溝通是雙向的一樣，能不能夠連線除了對方要願意之外，你自己的機器也要允許這件事。

一般來說，不會阻擋這件事，但是如果今天你的電腦是別的地方提供，或許因為資安考量會不允許做這件事。

所以，要驗證這個，最快的方式其實是==換一台電腦試試看==最快。

不過，假設沒辦法換電腦，那麼可以檢查看看作業系統的防火墻，以 Windows 為例：

1. 打開防火墻設定。可以用：快捷鍵`Win + r`​ 然後輸入 `wf.msc`​  
    ^^^  
    ​![Run 執行 wf.msc](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215064057-k826iga.png "Run 執行 wf.msc"){.img-responsive}  
    ^^^Run 執行 wf.msc
2. 切換到 `Outbound Rules`​ 然後檢查有沒有 `Remote Port`​設定是 `3389`​然後被==不允許連線==

    ^^^  
    ​![Windows Firewall 的設定畫面](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215064322-okzm766.png "Windows Firewall 的設定畫面"){.img-responsive}  
    ^^^Windows Firewall 的設定畫面

### 確認一下是不是你的網路環境導致連線不進去

到目前為止的環境排查都是針對自己可以掌控的部分。

不過，網路有很多層級，有可能在別的層級就擋下來了，這個最多發生在如果公司內部的網路政策不允許做這件事。

這個最好的排查方式是：==換一個網路==。

例如，連上自己的 4G 網路試試看是否就好了。

:::{.bs-callout .bs-callout-info}
這個搭配上一個建議就是，換機器也換網路，如果就通了，至少是這兩個之一
:::

### 確認一下是不是因為忘記了帳號密碼所以導致連不進去

假設都到了這邊，一般來說已經排除了大部分的環境問題，那麼接下來要問一些看起來很明顯的問題。

例如，你的帳號密碼有沒有記錯/輸入錯誤？

這個錯誤訊息和連線不到的訊息其實長的不一樣，不過不一定大家都有認真看。

^^^  
​![帳號密碼錯誤截圖](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215065311-6rfc7r4.png "帳號密碼錯誤截圖"){.img-responsive}  
^^^帳號密碼錯誤截圖

假設是 Azure VM 遇到這個，可以透過 `Reset password`​ 來解決：

^^^  
​![Azure VM 的 Reset Password 畫面](/posts/2023/02/2023-02-11-faq-how-to-troubleshoot-azure-virtual-machine-connection-remote-desktop-issue/image-20230215065429-8cbwgw9.png "Azure VM 的 Reset Password 畫面"){.img-responsive}  
^^^Azure VM 的 Reset Password 畫面

1. 在左邊找到 `Reset password`​
2. 輸入登入帳號
3. 輸入登入密碼
4. 再輸入一次密碼
5. 最後按下 `Update`​

大概等個幾分鐘讓他執行，在嘗試一次

## 總結

一般來說，如果上面的流程都走完，那麼連線一般就不太會有問題。

假設上面廢話太多，懶得看，大家只要記得一個規則，那麼可以從：

1. 換機器
2. 換環境
3. 重新建立 VM （避免例如不小心把 Public IP 刪掉之類的）

基本上就沒問題啦。

如果你有更好的排查方式，歡迎和我分享哦。

‍
