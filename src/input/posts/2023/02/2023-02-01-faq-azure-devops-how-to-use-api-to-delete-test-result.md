Title: "怎麼在 Azure DevOps Test Plan 刪除 Test Result - 了解如何用 API 溝通 | FAQ"
Published: 2023-02-01 19:00
Modified: 2023-02-01 19:00
Tags: [ 「Azure DevOps」]
Series: [「Azure DevOps」]
PostDescription: "Azure DevOps 是一個把整個開發生命週期用到的工具都包在一起的服務。他的 UI 提供很多功能，不過總會遇到有些功能是 UI 沒有提供，或者假設我們今天想要自動化的時候，就可以透過 API 來達到這件事。

但是，想用 API 可以怎麼用呢？

這篇，就透過想刪掉 Azure DevOps Test Result 這個需求看看怎麼用 Azure DevOps API 做到這件事"


---

Azure DevOps 是一個微軟提供的 End to End 的軟體開發工具。從需求管理到最後面的 Test 或者 Artifact 管理涵蓋了這個軟體開發的生命週期。

我曾經有幾個影片介紹過 [Azure DevOps](/tags/「azure-devops」) 裡面和 Test 有關的功能：

<iframe width="560" height="315" src="https://www.youtube.com/embed/GhqTIzDqV5A" data-src="https://www.youtube.com/embed/GhqTIzDqV5A" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen=""></iframe>

前陣子有人問我，如果需要刪掉 Test Plan 裡面的 Test Result 可以怎麼做到這件事？

去查了一下，微軟沒有開放操作界面做這件事，不過有==提供 API==。所以是可以達成。

雖然說這篇主要是針對 Azure DevOps Test Result 進行操作，但是一樣的概念可以用作於想透過 API 來管理 Azure DevOps 但是不知道怎麼做（例如自動化抓資料來產生績效報表），那這篇也可以節省你一些研究時間。

<!--more-->

## 執行順序

1. 先抓出要刪除的 Test Result Id
2. 準備好要打 API 的 token
3. 執行刪除的 API

## 先抓出要刪除的 Test Result Id

假設我們要刪除的那個 Test Result 的那筆資料如下

^^^  
​![要刪掉的 test result](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208065432-bm2hnzq.png "要刪掉的 test result"){.img-responsive}  
^^^要刪掉的 test result

API 需要有 3 個參數：

1. ​`organization`​ - Azure DevOps 的組織名稱。會是網址 Host 的一部分。
2. ​`project`​ - 專案的名稱
3. ​`runId`​ - 測試結果的 Id

這 3 個參數可以從結果那頁看到：

^^^![範例資料](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208072537-mn77fk0.png "範例資料"){.img-responsive}  
^^^範例資料

以上面的範例來說：

1. ​`organization`​ 就是：`alantsai-sample`​
2. ​`project`​ 就是：`TestPlanProject`​
3. runId 就是：`1000028`​

## 準備好要打 API 的 token

^^^  
​![找到 Personal Access Token 的位置](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208070323-gh317jy.png "找到 Personal Access Token 的位置"){.img-responsive}  
^^^找到 Personal Access Token 的位置

1. 先點右上角帳號頭像左邊的人像 icon
2. 找到倒數第二個的 Personal access tokens - 也可以簡稱為 PAT

^^^  
​![建立 PAT](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208070606-ys3otx7.png "建立 PAT"){.img-responsive}  
^^^建立 PAT

1. 選擇 `New Token`​
2. 輸入自己會記得的名臣到 `Name`​
3. 在 `Scopes`​ 的部分選擇 `Test Management => Read & write`​
4. 選擇 `Create`​

:::{.bs-callout .bs-callout-info}
這邊還可以設定多久會失效等。越短越好哦。或者用完之後刪掉 PAT。
:::

^^^  
​![看到 PAT](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208070806-s56slz1.png "看到 PAT"){.img-responsive}  
^^^

下個畫面會看到一組亂碼，就是 PAT 碼。

記得把它存下來。

:::{.bs-callout .bs-callout-warning}
記得不要把 PAT 給別人，不然別人可以做和你一樣的操作
如果這邊沒有儲存下來，那麼就要建立新的 PAT
:::

## 執行刪除的 API

要執行的 API 是這個：[Runs - Delete](https://learn.microsoft.com/en-us/rest/api/azure/devops/test/runs/delete?view=azure-devops-rest-6.0&tabs=HTTP&WT.mc_id=AZ-MVP-5003856&fbclid=IwAR3rqzDM80x4k2ubBFPIF6MTfXrPTRjQmBVFYHs4robI4cs8Ze7h_XiEShA)

我們可以用這個工具協助我們：[hoppscotch](https://hoppscotch.io/)

API 的網址是：`DELETE https://dev.azure.com/{organization}/{project}/_apis/test/runs/{runId}?api-version=6.0`​

只要 `{}`​ 這種的都要替換成為我們上面得到的值，以我的為例就是：
`DELETE https://dev.azure.com/alantsai-sample/TestPlanProject/_apis/test/runs/1000028?api-version=6.0`​

^^^  
​![設定要輸入的內容](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208072735-oesd89i.png "設定要輸入的內容"){.img-responsive}  
^^^設定要輸入的內容

1. 先選擇到 `DELETE`​
2. 把上面組出來那個網址放進去
3. 選擇 `Authorization`​ 這個 Tab
4. 把 `Authorization Type`​ 改成 `Basic Auth`​
5. 把登入用的帳號輸入進去
6. 把稍早 PAT 的內容輸入裡面的輸入框作為密碼

最後我們可以按網址旁邊的 `Send`​ 去做執行

^^^  
​![執行結果](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208072914-s5kl23q.png "執行結果"){.img-responsive}  
^^^執行結果

1. 點下 `Send`​ 這個按鈕
2. 會看到下面回傳結果是 `204`​ 代表有執行成功

回到 Azure DevOps 會看到結果不見了

^^^  
​![刪掉成功](/posts/2023/02/2023-02-01-faq-azure-devops-how-to-use-api-to-delete-test-result/image-20221208073047-tt14bpd.png "刪掉成功"){.img-responsive}  
^^^刪掉成功

:::{.bs-callout .bs-callout-warning}
注意：刪掉之後就不見了哦。最好先拿一些不重要的測試看看。
:::

## 結語

這篇主要介紹了如何透過 API 的方式來達到刪除 Azure DevOps 的 Test Result。

如果和 Azure DevOps 的互動想要自動化並且節省一些時間，那麼透過 API 是一個最好的方式。這篇取得 PAT 等方式都是適用，剩下只是研究一下想做的事情的 API 怎麼呼叫而已。

如果用 Azure DevOps 來管理單子，那麼只要規則訂好績效報表可以用自動化產出，或許就可以剩下你非常多時間哦。

如果你有什麼用法歡迎留言分享哦。