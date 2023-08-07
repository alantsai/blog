Title: "怎麼可以避免資源被誤刪？所有 Production 環境都應該要上 Resource Lock"  
Published: 2022-11-04 19:00  
Modified: 2022-11-04 19:00  
Image: "/posts/2022/11/2022-11-04-azure-how-to-use-resource-lock-to-prevent-accidental-deletion-resource/image-20230318195029-h02qz58.png"  
Tags: [ azure]  
Series: []  
PostDescription: "在剛用 Azure 的人來說，有時候會區分不出要避免資料誤刪，到底應該使用所謂的 RBAC 還是 Resource Lock。這篇來看一下什麼時候應該使用什麼"

---

當真的開始要在正式環境管理 Azure 資源的時候，就會開始遇到一些管理上面的問題

舉例來說，不應該給權限的就不應該要給。譬如說假設某些人員不應該有刪除的權限，那麼就不應該給他

但是假設今天是他本來就應該==有權限==，但是不小心==誤刪==怎麼辦？

或者說把 Production 機器誤以為 QA 環境結果把機器給關機了怎麼辦？

這個時候就不是設定權限給太大的問題

這時候就應該要好好利用 Resource Lock

這篇，來看一下 Resource Lock 是什麼以及該怎麼用

<!--more-->

## 什麼是 Resource Lock？

其實概念很簡單，在要被保護的資源上面可以上一個鎖頭避免==不小心==刪掉

這個鎖頭可以被設定在：

1. Subscription
2. Resource Group
3. Resource

這三個層級裡面，並且會被從上往下繼承

鎖又可以區分兩種：

1. Read-Only

    1. 代表資源變成只能夠讀，不能夠做任何==異動==
2. Delete

    1. 代表資源不能夠==被刪除==

這兩個類型的鎖最大差異在於 Read-Only 更加嚴謹

舉例來說，如果有台 VM 目前是==開機狀態==，如果有被鎖上 Read-Only Lock，代表不能夠被關機。原因很簡單，因為開關機會==異動==機器的狀態

所以如果有上了 Read-Only Lock，代表不會被==不小心關機==

## 嘗試設定 Resource Lock 在 Resource Group 上面並且嘗試刪除

​![image](/posts/2022/11/2022-11-04-azure-how-to-use-resource-lock-to-prevent-accidental-deletion-resource/image-20230318195029-h02qz58.png "Resource Lock 的設定"){.img-responsive}

1. 先找到某一個 Resource Group，然後從左邊搜尋 `Lock`​
2. 選擇上面的 `Add`​
3. 可以設定 Lock 的名稱
4. 可以設定 Lock 的類型
5. 可以加上描述

以上面操作為例，是加上一個 Delete Resource Lock，加好之後，當我們想要刪 Resource 的時候就會出現錯誤

​![image](/posts/2022/11/2022-11-04-azure-how-to-use-resource-lock-to-prevent-accidental-deletion-resource/image-20230318195200-03ooejw.png "被鎖住的沒辦法被刪掉"){.img-responsive}  
^^^ 被鎖住的沒辦法被刪掉

## 結語

Resource Lock 是一個在正式環境都要利用起來的設定

只有這樣，才可以避免不小心資源被刪掉的問題
