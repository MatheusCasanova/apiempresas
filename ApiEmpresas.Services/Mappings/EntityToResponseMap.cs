﻿using ApiEmpresas.Infra.Data.Entities;
using ApiEmpresas.Services.Responses;
using AutoMapper;

namespace ApiEmpresas.Services.Mappings
{
    /// <summary>
    /// Mapeamento de objetos ENTITY para RESPONSE (OUTPUT da API)
    /// </summary>
    public class EntityToResponseMap : Profile
    {
        public EntityToResponseMap()
        {
            CreateMap<Empresa, EmpresaResponse>();
            CreateMap<Funcionario, FuncionarioResponse>();
        }
    }
}
