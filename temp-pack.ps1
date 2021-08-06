#Variáveis 
Write-Output ""
Write-Output "Setando variáveis"
$WorkingDir = $PSScriptRoot 
Write-Output "Work Dir: $WorkingDir"
$packageDir = "C:\repos\nuget" 
Write-Output "Package Dir: $packageDir"
Write-Output ""

#Setando pasta projeto
Write-Output "Iniciando script local packages"
Set-Location $WorkingDir

#Rodar o comando de build
Write-Output "Buildando os projetos"
dotnet build components-backend-core.sln  -v q

#Limpar pasta destino
Write-Output "Removendo Arquivos temporários ($packageDir)"
Set-Location $packageDir
Remove-Item *

#Rodar o comando de package

Write-Output "Voltando ao diretório do projeto"
Set-Location $WorkingDir
dotnet pack --output $packageDir --no-build

#Verificando geração do pacotes
Write-Output "Listando pacotes temporários ($packageDir)"
Set-Location $packageDir
Get-Item *
