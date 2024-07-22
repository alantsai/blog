# Blog

這個是部落格[Alan Tsai的學習筆記](http://blog.alantsai.net)的原始内容。

## 安裝 (install)

由於底層用到 Waym，因此需要有 [.NET Core 2.1 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/2.1/runtime?cid=getdotnetcore&os=windows&arch=x64)

## 快速使用 (getting started)

整個專案使用Cake作爲Build Script，因此在build、Deploy或者preview部落格都可以使用cake啓動。

總共有以下幾個情景：

1. Build
2. Preview
3. Deploy

> 以下提到的指令都是使用 **powershell** 做執行，并且 **powershell** 的目前資料夾位置在 **根** (和 `.gitignore` 同一層級)。

### 1. Build

這個Task的主要目的是把部落格文章建立成爲靜態html網站内容，執行完的結果是會有個 `.\src\output` 資料夾被建立出來并且裏面是最後的html。

執行指令如下：

```powershell
.\build\build.ps1
```

### 2. Preview

這個Task會把部落格build起來然後啓動preview（一個内建的server，預設port `5080`）并且會一直watch。

換句話説，只要内容有改，會自動重新build并且reload。

適合寫文章看效果用

執行指令如下：

```powershell
.\build\build.ps1 -target Preview
```

### 3. Deploy

把build出來的内容Deploy到[netlify.com](https://www.netlify.com/)。

執行指令如下：

```powershell
.\build\build.ps1 -target Deploy -ScriptArgs '-NETLIFY_TOKEN="xxxx"', '-SITE_NAME="blog-staging.netlify.com"'
```

這邊有兩個參數：

1. **NETLIFY_TOKEN** - 由於要把網站部署到netlify，因此需要傳入有權限的Personal Access Token。  

2. **SITE_NAME** - 這個是要部署上去的網站名字。如果重來沒有建立過，可以先隨便上傳一個zip，讓他建立一個random的site名稱，之後在該site的名字

> 這兩個參數會優先從 **Environment Variable** 取得，因此，如果今天接自動部署的話，可以用Environment Variable來設定

### 如何看到更詳細的cake log

如果有發生問題，想要看更詳細的log，請在執行 `build.ps1`的時候加入一個參數 `-verbosity Diagnostic`。

例如：

```powershell
.\build\build.ps1 -target Deploy -ScriptArgs '-NETLIFY_TOKEN="xxxx"', '-SITE_NAME="blog-staging.netlify.com"' -verbosity Diagnostic
```

## 授權 (License)

原始碼的部分屬於 MIT License，更多資訊請看 [LICENSE.md](LICENSE.md)

部落格文章内容則屬於[創用CC 姓名標示 4.0 國際 授權條款](http://creativecommons.org/licenses/by/4.0/)
