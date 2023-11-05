FROM mcr.microsoft.com/dotnet/sdk

# Installing Required Packages
RUN     wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
        dpkg -i packages-microsoft-prod.deb && \
        apt-get update && \
        apt-get upgrade -y && \
        apt-get install -y git curl && \
        apt-get install tmux -y && \
        apt-get install -y dotnet-runtime-6.0 && \
        apt-get install -y aspnetcore-runtime-6.0 && \
        dotnet dev-certs https --trust


# Installing NodeJS
RUN     curl -fsSL https://deb.nodesource.com/setup_14.x | bash - && \
        apt-get install -y nodejs

RUN     git clone https://github.com/joydipkanjilal/MVC.Demo