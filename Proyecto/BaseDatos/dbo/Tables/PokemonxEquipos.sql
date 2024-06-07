CREATE TABLE [dbo].[PokemonxEquipos] (
    [IdPokemon] UNIQUEIDENTIFIER NOT NULL,
    [IdEquipo]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PokemonxEquipos] PRIMARY KEY CLUSTERED ([IdPokemon] ASC, [IdEquipo] ASC),
    CONSTRAINT [FK_PokemonxEquipos_Equipos] FOREIGN KEY ([IdEquipo]) REFERENCES [dbo].[Equipos] ([IdEquipo]) ON UPDATE CASCADE,
    CONSTRAINT [FK_PokemonxEquipos_Pokemon] FOREIGN KEY ([IdPokemon]) REFERENCES [dbo].[Pokemon] ([Id]) ON UPDATE CASCADE
);

