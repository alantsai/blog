Title: "Azure 的 Virtual Machine 規格這麼多，怎麼挑選適合的？Azure VM Selector 工具介紹"  
Published: 2023-01-04 19:00  
Modified: 2023-01-04 19:00  
Image: "/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230315062704-s0415uk.png"  
Tags: [ azure, tool]  
Series: []  
PostDescription: "第一次接觸 Azure 一般都是從 Virtual Machines 開始。不過 Azure 有 700+ 以上的 VM 規格，真的到了 production，到底應該怎麼挑選？這篇來看一下怎麼使用 Azure VM Selector 這個工具"

---

​![Azure VM 規格 707 種到底應該選那個？](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230315062704-s0415uk.png "Azure VM 規格 707 種到底應該選那個？"){.img-responsive}
^^^ Azure VM 規格 707 種到底應該選那個？


剛接觸 Azure 的使用者，第一個看的服務一般來說會是 Virtual Machine (VM)

這時候會遇到的第一個問題就是，規格這麼多，到底那個規格是適合的？

這篇我們來介紹其中的一個工具 Azure VM Selector，看看能夠怎麼協助我們

<!--more-->

## Azure VM Selector 是什麼？怎麼用

它是一個線上的工具，可以在這邊存取的到：

[https://azure.microsoft.com/en-us/pricing/vm-selector/?WT.mc_id=AZ-MVP-5003856](https://azure.microsoft.com/en-us/pricing/vm-selector/?WT.mc_id=AZ-MVP-)

就會看到以下畫面：

​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317145341-b0lb60e.png "Azure VM Selector 的開始畫面"){.img-responsive}  
^^^ Azure VM Selector 的開始畫面

可以依照三個不同的角度來找到適合的機器規格：

1. 依照使用情境（Workload）
2. 依照作業系統和軟體
3. 依照 Region

如果今天是從地端到雲端，有個很明顯想用的作業系統和軟體就可以從第二個開始。

舉例來說，假設今天的需求是需要一台：

1. Windows Server 2022
2. SQL Server Enterprise 2022
3. 16 GB 記憶
4. 4 CPU

那麼可以跟著以下步驟：

1. 選擇：`Find VMs by OS and software`​

    ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317145709-r3pgyqm.png "選擇 Find VMs by OS and software 的 Start Here"){.img-responsive}  
    ^^^ 選擇 Find VMs by OS and software 的 Start Here
2. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317145808-vypumf8.png "選擇 Windows，SQL Service，然後 SQL Enterprise，可以注意右邊的 VM 數量"){.img-responsive}  
    ^^^ 選擇 Windows，SQL Service，然後 SQL Enterprise，可以注意右邊的 VM 數量
3. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317145916-9fonz4r.png "選擇什麼類型的 VM"){.img-responsive}  
    ^^^ 選擇什麼類型的 VM
4. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317150009-n6d5cbi.png "設定想要的 CPU、Memory - 可以注意到右邊的 VM 數量大幅度的減少了"){.img-responsive}  
    ^^^ 設定想要的 CPU、Memory - 可以注意到右邊的 VM 數量大幅度的減少了
5. 如果有些特殊需求，可以點下面的 `Additional VM features`​  
    ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317150204-xue540x.png "進一步下不同的篩選條件"){.img-responsive}  
    ^^^ 進一步下不同的篩選條件
6. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317150331-7cxm21d.png "選擇硬碟的規格 - 如果不確定可以點開 spec 會呈現更多詳細資訊"){.img-responsive}  
    ^^^ 選擇硬碟的規格 - 如果不確定可以點開 spec 會呈現更多詳細資訊
7. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317150436-yp4z4zf.png "實際設定要幾個硬碟和要多大空間"){.img-responsive}  
    ^^^ 實際設定要幾個硬碟和要多大空間
8. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317150512-gae4hnq.png "最後選擇 Region"){.img-responsive}  
    ^^^ 最後選擇 Region
9. ​![image](/posts/2023/01/2023-01-04-azure-tool-how-to-find-appropriate-vm-sku-using-azure-vm-selector/image-20230317151228-x6pu6nz.png "可以切換看到所有推薦的機器規格、可以點了看詳細資訊，或者直接加入計算機"){.img-responsive}  
    ^^^ 可以切換看到所有推薦的機器規格、可以點了看詳細資訊，或者直接加入計算機

## 結語

透過 Azure VM Selector，可以在知道需要什麼規格的情況下快速找到最適合的 Azure VM。

不過假設今天是要反過來呢？

例如，我已經有某個 Azure VM 規格，我想要知道還有沒有更推薦的可以怎麼做？

下一篇介紹一下 Azure VM Comparison
