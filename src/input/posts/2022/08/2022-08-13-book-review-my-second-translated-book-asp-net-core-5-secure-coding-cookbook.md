Title: "沒想到還有第二本翻譯書：ASP.NET Core 工程師不可不知的 10 大安全性漏洞與防駭方法 (ASP.NET Core 5 Secure Coding Cookbook) | 書評"
Published: 2022-08-13 19:00
Modified: 2022-08-13 19:00
Image: "posts/2022/08/2022-08-13-book-review-my-second-translated-book-asp-net-core-5-secure-coding-cookbook/image-20220816223225-4sesg5d.png"
Tags: [ 書評, security]
Series: []
PostDescription: "之前翻譯完第一本書，想說應該不會在翻譯
沒想到人生還有第二本翻譯書，也是編輯抬愛
相較於第一本比較偏結構面
這本可就和 coding 很有關係
是每一個工程師都應該要有的概念：Secure Coding

資訊安全是一個會一直不斷冒出來的議題，從一開始就要考慮進去
如果不知道從哪裡下手，OWASP Top 10 是最好的開始點
不過如果看文字描述有看沒有懂，那麼直接看 code 最有感
這本書就是如此，一起來看看這本和 secure coding 有關的武功秘籍吧"

---

^^^
​![image](/posts/2022/08/2022-08-13-book-review-my-second-translated-book-asp-net-core-5-secure-coding-cookbook/image-20220816223225-4sesg5d.png "實體書收到啦")
^^^ 實體書收到啦

自從人生的第一本翻譯書弄完之後，我本來想說應該不可能有第二本了。

沒想到，編輯問我說剛好有一本和 ASP.NET Core 以及資安有關的書，看我有沒有興趣。

然後又是一個半年過去，才翻譯完。

作為人生的第二本翻譯書，就要來和大家介紹一下，它是一本什麼內容的書，以及什麼人適合。

<!--more-->

## 書籍的資訊介紹

這本書之前有預購的應該已經都收到了，有興趣的可以參考天瓏：

:::{.bs-callout .bs-callout-info}
* 適合群眾：任何 Web Developer 對於怎麼實作防護 OWASP TOP 10 有關問題的人。如果是 ASP.NET Core 開發者更好，因為範例程式碼用 ASP.NET Core。
* 購買網址：[https://www.tenlong.com.tw/products/9786263331808](https://www.tenlong.com.tw/products/9786263331808)
* 範例程式碼：[https://github.com/PacktPublishing/ASP.NET-Core-Secure-Coding-Cookbook](https://github.com/PacktPublishing/ASP.NET-Core-Secure-Coding-Cookbook)
:::

## 這本書到底在說什麼

### Secure Coding 這件事

作為一個 Developer，寫出來的程式碼除了不能髒髒的之外，安全也是我們需要納入的第一考量。
常常因為時程的關係，想說最後再來處理，但是如果沒從第一天就有這種 ==Secure Coding== 的概念的話，後面要在補上就變得非常麻煩。因為不安全的 code 可能已經散落在整個程式碼裡面了。

那怎麼培養這種 Secure Coding 的概念呢？最簡單當然就是常接觸和資安有關的議題，接觸多了就了解網路的世界有多恐怖 😁。

那從那邊開始下手呢？

有在寫 Web 的一定有聽說過 OWASP（The Open Web Application Security Project） 這個組織。簡單來說他們會定期去搜集和研究網路安全這個部分，並且會持續更新一個清單稱之為 ==OWASP Top 10==。

這個 Top 10 代表的是網路安全最需要注意到的 10 個常被攻擊的方式。

譬如說大家最常聽到的 SQL Injection 就是常年位居前三的攻擊方式。（題外話，隨著大家越來越有這方面的意識，最近 Injection 類型的攻擊從本來的榜首掉到了第 3 名，算是可喜可賀吧）。

其他的可能還有什麼 Cross Site Scripting (XSS) 攻擊，Client Side Request Forgery (CSRF) 等，相信要上線前的資安掃描多多少少大家都有看過類似的問題出現在報告裡面。

就算你知道了 OWASP Top 10 之後，很認真的去閱讀，很有可能還會搞不清楚這個描述的攻擊到底是什麼。

先不說內容是英文（有好心的大大會翻成中文）會有一點點的阻力，在加上大部分都是用==文字==描述方式說明這個攻擊是什麼、什麼危害然後怎麼防範。可是如果作為一個從來都沒有接觸過的人，光看這個其實很難有感。

舉個例子來說：我們都知道 SQL Injection 要注意，但是你真的知道：

* SQL Injection 是怎麼被用來攻擊
* 會造成什麼後果嗎？

這個時候有個範例的程式碼呈現出：

* 有問題的 code 長什麼樣子
* 實際在運作的時候，會受到怎麼樣的攻擊
* 怎麼修復好

知道怎麼運作，對於我們怎麼防護，就會對學習上很有幫助啦。

而這本書正式使用這種模式在和大家介紹每一個攻擊。

### 書的組成

這本書基本上屬於 Cookbook 類型。

什麼意思呢？就是說像食譜一樣，今天你想做某一道菜，你就會去看某一個食譜，裡面就會告訴你從材料有什麼，然後到一步一步怎麼把它做出來。

不過我自己其實比較喜歡稱之為武功秘籍，每一個招式/套路（食譜）就是對應到一個情境，讓你看完之後再也不怕說不出什麼是【不安全的反序列化】等安全問題。

每一個章節對應到一個資安議題，不用說 OWASP Top 10 都有涵蓋到。

資安議題還會有一些變形，所以每一章在介紹每一個攻擊都會在分為三個部分：

準備
:    要跑這個範例需要注意什麼

如何做到這一點...
:    執行這段的細節步驟

它是如何運作的...
:    說明整個運作的機制

透過這三個部分，用程式碼的方式帶出整個問題。

不過這並不代表世界上只有 10 種攻擊，所以 Top 10 之外還有其他一些常見的攻擊也有被列出來做說明，以及一些最佳實踐。

### 適合群眾

我個人認為其實適合所有開發者，因為有些攻擊是不管你今天寫什麼都會用到。

譬如說，任何應用程式都有資料庫，那 Injection 類型就要小心。

或許你會說，都什麼年代了還在資料庫，我們都是用 NoSQL 😁，那其實一樣會有其他的問題要注意，例如【不安全的反序列化】。

所以，雖然 OWASP 是面向以 Web 技術為主，但是其實不管今天是什麼類型都會遇到。

所以，如果今天你是：

* 開發人員 - 尤其是 .NET 世界的開發人員
* 對於 Secure Coding 有興趣的人
* 對於想要知道這些資安攻擊怎麼執行的人
* 理論看了想睡覺，想要從 Code 學習的人

那這本書都滿適合。

### 範例程式碼

上面其實提到滿多次關於有個可以看到問題並且可以嘗試的 code 對學習上很有幫助。

這邊不得不提一下關於範例程式碼。

首先先說一下，這本書的範例用的是 ASP.NET Core 5 作為範例。

某種程度上大家會疑惑，那到了 ASP.NET Core 6 或者未來還適不適用？

基本上，概念都是一樣的，並且裡面介紹到的套件都是比較知名的套件，因此不用太過於擔心會不會有沒辦法用的問題。

範例程式碼用 `before` 以及 `after` 的方式讓大家可以直接 run 起來看看差異，所以對於喜歡從 code 學習的人來說屬於非常方便的一種方式啦。

## 結語

以上就是這本書的介紹。

如果大家對於裡面的內容有什麼問題，都歡迎敲我哦。

## 參考資料

* [OWASP Top 10](https://owasp.org/www-project-top-ten/) - 英文版本的頁面，裡面列出了 2017 年和 2021 年差異比較，並且每一個攻擊的細節都可以點進去。
* [OWASP Top 10 2017 中文版（PDF）](https://wiki.owasp.org/?title=Special:Redirect/file/OWASP_Top_10_2017_%E4%B8%AD%E6%96%87%E7%89%88v1.3.pdf)- 英文苦手的救星，不過這個是 2017 年的版本哦。
* Code Review 的參考指南 - Code Review 到底要看什麼呢？尤其是資安面

  * [OWASP Code Review Guide](https://owasp.org/www-pdf-archive/OWASP_Code_Review_Guide_v2.pdf)
  * [Google Code Review Guide](https://google.github.io/eng-practices/review/)
