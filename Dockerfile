FROM mcr.microsoft.com/dotnet/sdk as base

WORKDIR /app
COPY . .
RUN dotnet build
RUN dotnet publish --configuation Debug -p PizzaBox.Client -o out PizzaBox.Client

FROM mcr.microsoft.com/dotnet/aspnet

WORKDIR /run
COPY --from=base /app/out .
CMD ["dotnet", "PizzaBox.Client.dll"]
