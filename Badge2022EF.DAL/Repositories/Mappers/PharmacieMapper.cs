﻿using Badge2022EF.DAL.Entities;
using Badge2022EF.Models.Concretes;

namespace Badge2022EF.DAL.Repositories.Mappers
    {
    public static class PharmacieMapper
        {
        public static Pharmacies ToModel(this PharmacyEntity Entity)
            {
            Pharmacies Pharmacie = new(Entity.Nom ?? "",
                                    Entity.Departement ?? "",
                                    Entity.Rue ?? "",
                                    Entity.Titulaires ?? "",
                                    Entity.Region ?? "",
                                    Entity.Url ?? "",
                                    Entity.Villes ?? "")
            {
                PharmacieId = Entity.Id
            };
            return Pharmacie;
            }

        public static PharmacyEntity ToEntity(this Pharmacies Model)
            {
            return new PharmacyEntity()
                {
                Id = Model.PharmacieId
                };
            }
        }
    }
