CREATE DATABASE [Exercise]
GO
ALTER DATABASE [Exercise] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Exercise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Exercise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Exercise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Exercise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Exercise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Exercise] SET ARITHABORT OFF 
GO
ALTER DATABASE [Exercise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Exercise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Exercise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Exercise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Exercise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Exercise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Exercise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Exercise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Exercise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Exercise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Exercise] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [Exercise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Exercise] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Exercise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Exercise] SET  MULTI_USER 
GO
ALTER DATABASE [Exercise] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Exercise] SET ENCRYPTION ON
GO
ALTER DATABASE [Exercise] SET QUERY_STORE = ON
GO
ALTER DATABASE [Exercise] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
USE [Exercise]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET OPTIMIZE_FOR_AD_HOC_WORKLOADS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
ALTER DATABASE [Exercise] SET  READ_WRITE 
GO
