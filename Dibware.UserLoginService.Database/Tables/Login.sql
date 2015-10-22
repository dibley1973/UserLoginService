CREATE TABLE [dbo].[Login] (
    [Username]                UNIQUEIDENTIFIER NOT NULL,
    [Password]                NVARCHAR (255)   NOT NULL,
	[IsLockedOut]				BIT NOT NULL DEFAULT((0)),
    [CreationDate]            DATETIME2 (3)    NULL,
	[ConfirmationToken]		NVARCHAR(128),
	[LastActivityDate]		 DATETIME2 (3)    NULL,
	[LastLoginDate]			 DATETIME2 (3)    NULL,
	[LastLockedOutDate ]	 DATETIME2 (3)    NULL,
	[LastPasswordSuccessDate] DATETIME2 (3)    NULL,
	[LastPasswordFailureDate] DATETIME2 (3)    NULL,
	[LastPasswordChangedDate] DATETIME2 (3)    NULL,
	[PasswordVerificationTokenExpirationDate] DATETIME2 (3)    NULL,
	[PasswordVerificationToken] NVARCHAR(128),
	[SuccessfulLogins]			INT		NOT NULL DEFAULT((0)),
	[UnsuccessfulLogins]		INT		NOT NULL DEFAULT((0)),
	[PasswordFailuresSinceLastSuccess]	INT NOT NULL DEFAULT((0)),
    CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([Username] ASC)
);

