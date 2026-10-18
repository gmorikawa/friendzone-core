FROM mcr.microsoft.com/dotnet/sdk:10.0
WORKDIR /workspace
ENV NUGET_PACKAGES=/opt/nuget-packages
ENV NuGetAudit=false
COPY Friendzone.csproj ./
RUN dotnet restore -p:NuGetAudit=false
COPY . .
CMD ["dotnet", "watch", "--non-interactive", "run", "--no-launch-profile"]
