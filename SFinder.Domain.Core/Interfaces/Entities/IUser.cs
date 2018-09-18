﻿using SFinder.Domain.Core.Entities;
using SFinder.Domain.Core.ValueObjects;
using System.Collections.Generic;

namespace SFinder.Domain.Core.Interfaces.Entities
{
    public interface IUser
    {
        IReadOnlyCollection<Cadastro> Cadastros { get; }

        void CriarNovoCadastro(Cadastro cadastro);
        void Rate(Rating rating);

    }
}
