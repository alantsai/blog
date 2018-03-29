[CmdletBinding()]
Param(
    [string]$netlifyToken,
    [string]$uploadZipPath,
    [string]$siteName
)

Invoke-WebRequest -Uri "https://api.netlify.com/api/v1/sites/$siteName/deploys" -ContentType application/zip `
    -Headers @{Authorization = "Bearer $netlifyToken"} -InFile $uploadZipPath -Method Post