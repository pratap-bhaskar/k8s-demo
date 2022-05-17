FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY ./bin/publish .
ENTRYPOINT ["dotnet", "BlazorApp.dll"]
EXPOSE 8080