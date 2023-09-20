CREATE TABLE [dbo].[TeacherTbl] (
    [TId]      INT          IDENTITY (100, 1) NOT NULL,
    [TName]    VARCHAR (50) NOT NULL,
    [TAddress] VARCHAR (50) NOT NULL,
    [TGender]  VARCHAR (10) NOT NULL,
    [TPhone]   VARCHAR (10) NOT NULL,
    [T]  VARCHAR (20) NOT NULL,
    [TDOB]     DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([TId] ASC)
);

