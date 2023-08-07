Title: "00-a 用 Azure Portal 管理資源 | AZ-104 課程 Lab 操作"  
Published: 2023-03-06 19:00  
Modified: 2023-03-06 19:00  
Image: "/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20220406133746-1096gel.png"  
Tags: [ azure, 「az104-lab」]  
Series: [「az104-lab」]  
PostDescription: "這個系列是 AZ 104 課程裡面所規劃的 Lab 用圖文方式呈現出要如何完成。
這個 lab 目的是透過建立 Resource Group、移動 Resource 以及加上 Resource Clock 來熟悉 Azure 的操作方式"

---

這個系列是 AZ 104 的線上課程裡面所規劃的 Lab 用圖文方式呈現出要如何完成

這個 Lab 的主要目的是讓學生熟悉如何使用 Azure Portal 去做資源管理

在這個 Lab 裡面總共有 3 個任務：

1. 任務 1：建立Resource Group並將資源部署到Resource Group
2. 任務 2：在Resource Group之間移動資源
3. 任務 3：實現和測試資源鎖

​![image.png](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20220406133746-1096gel.png "https://microsoftlearning.github.io/AZ-104-MicrosoftAzureAdministrator/Instructions/Labs/LAB_03a-Manage_Azure_Resources_by_Using_the_Azure_Portal.html"){.img-responsive} 

<!--more-->

## 任務 1：建立Resource Group並將資源部署到Resource Group

1. 登錄到 [Azure Portal](https://portal.azure.com)
2. 在 Azure Portal中，搜索並選擇 **Disks，**並且按下 <kbd>Create</kbd>​ 的選項

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318222208-m9dytmg.png "找到 Disks 並且選擇 Create"){.img-responsive} 
3. 設定 Resource group 以及 Disk name

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318222344-llzlji4.png "設定 Resource group 以及 Disk name"){.img-responsive} 
4. 調整 Disk 規格 **Standard HDD** 和 **32 GiB**

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318222547-kquti24.png "在 Disk 選擇 Change Size"){.img-responsive} 

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318222518-n63htcs.png "調整 Disk 規格 Standard HDD 和 32 GiB"){.img-responsive} 
5. 單擊 **Review + Create**，然後單擊 **Create**。

    > **備注**： 等待磁盤建立完成。所需時間應該不超過一分鐘。
    >

## 任務 2：在Resource Group之間移動資源

把上個任務移動到新的 Resource Group

1. 進入 Resource Group
2. 找到 `az104-00a-rg1`​ 這個 Resource Group  
    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318222955-rgpao8j.png "找到 `az104-00a-rg1` 這個 Resource Group"){.img-responsive} 
3. 進入 Resource Group 並且勾選要移動的資源

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318223143-det57dp.png "進入 Resource Group 並且勾選要移動的資源"){.img-responsive}
4. 在移動的畫面，選擇建立新的 `az104-00a-rg2`​ 的 Resource Group

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318223314-q0mp3e0.png "在移動的畫面，選擇建立新的 `az104-00a-rg2` 的 Resource Group"){.img-responsive}

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318223622-blnuml0.png "檢查通過可以按下 Next"){.img-responsive}

    ​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318223651-1zqhcu6.png "勾選理解會產生出新的 resource id 然後按下 Move"){.img-responsive}

## 任務 3：實現和測試資源鎖

1~4 步重複任務 1 的內容，不過這次建立的：

1. Resource Group = az104-00a-rg3
2. Disk name = az104-00a-disk2

5~6 步接下來是要加入 Resource Lock

​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318224238-7hhqilj.png "在 resource group 找到 Locks 然後建立出一個 delete lock"){.img-responsive} 

7~9 步接下來是要驗證鎖有效果

​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318224422-llxj4ch.png "嘗試刪除 Resource Group"){.img-responsive}

​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318224444-2bxc3lz.png "跳出訊息 - 刪不掉因為有鎖"){.img-responsive} 

10~11 步是嘗試調整 Disk 規格

由於我們不是用 Read-Only Lock，所以預期是可以被異動

​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318224612-i9r6jcr.png "嘗試調整 Disk 的規格"){.img-responsive}

​![image](/posts/2023/03/2023-03-06-az104-lab-familiar-azure-portal-by-create-resource-group-move-resource-resource-lock/image-20230318224637-bv0ison.png "異動成功"){.img-responsive} ​

‍
