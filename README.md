
# JornadaTrabalho API – Futuro do Trabalho 2030+

## Integrantes
- **Enricco Rossi de Souza Carvalho Miranda** - RM551717  
- **Guilherme Silva dos Santos** - RM551168  
- **Sofia Amorim Coutinho** - RM552534

## 1. Descrição Geral
A JornadaTrabalho API é uma solução RESTful desenvolvida em .NET para registrar e monitorar as ações realizadas por colaboradores durante sua jornada de trabalho, incluindo horários, eventos e interações automatizadas. A aplicação está alinhada ao tema “O Futuro do Trabalho”, promovendo automação, coleta de dados e integração com IoT.

## 2. Tecnologias Utilizadas
- .NET 8 / ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- Swagger / OpenAPI  
- Azure App Service  

## 3. Arquitetura da Solução


<img width="1600" height="746" alt="diagram (1)" src="https://github.com/user-attachments/assets/2dc3fe47-c5d3-4c86-9f61-0aaa19862958" />

```
[Dispositivo IoT] → HTTP → [API JornadaTrabalho]
API → EF Core → [SQL Server Database]
Aplicativos / Dashboards → API → Dados consolidados
```

## 4. Versionamento da API
Padrão utilizado:
```
/api/v1/eventos
/api/v1/jornada
/api/v1/colaboradores
```

## 5. Endpoints Principais
Documentação completa via Swagger:

https://jornadatrabalhoapi20251118140344-hnhyejhnh2hdfyb0.brazilsouth-01.azurewebsites.net/swagger/index.html

## 6. Persistência
A API utiliza Entity Framework Core com Migrations e SQL Server.

Comandos:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 7. Como Rodar Localmente
1. Clonar o repositório:
```
git clone <link>
cd JornadaTrabalhoApi
```

2. Configurar `appsettings.json` com a Connection String.

3. Rodar:
```
dotnet run
```

4. Acessar Swagger:
```
http://localhost:5000/swagger
```

## 8. Deploy em Produção
A API está publicada em Azure:

API:  
https://jornadatrabalhoapi20251118140344-hnhyejhnh2hdfyb0.brazilsouth-01.azurewebsites.net/

Swagger:  
https://jornadatrabalhoapi20251118140344-hnhyejhnh2hdfyb0.brazilsouth-01.azurewebsites.net/swagger/index.html

## 9. Vídeo Demonstrativo
https://youtu.be/lPk_komOumc

## 10. Conformidade com Requisitos da Global Solution
- ✔ Boas práticas REST  
- ✔ Versionamento  
- ✔ Banco + EF + Migrations  
- ✔ Swagger documentado  
- ✔ Arquitetura documentada  
- ✔ Deploy em Cloud  
- ✔ README completo  



