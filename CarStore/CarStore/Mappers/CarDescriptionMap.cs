using CarStore.Models;
using CarStore.Models.Entity;
using System.Collections.Generic;

namespace CarStore.Mappers
{
    public static class CarDescriptionMap
    {
        public static CarDescription AsDomain(this CarDescriptionEntity entity)
        {
            CarDescription domainObject = null;
            if (entity != null)
            {
                domainObject = new CarDescription
                {
                    Id = entity.Id,
                    Model = entity.Model,
                    Year = entity.Year,
                    Description = entity.Description,
                    Image = entity.Image,
                    Price = entity.Price,
                    Currency = entity.Currency,
                    CarFeatures = entity.CarFeatures.AsDomain()
                };
            }

            return domainObject;
        }

        public static CarDescriptionEntity AsEntity(this CarDescription domainModel)
        {
            CarDescriptionEntity statement = null;
            if (domainModel != null)
            {
                statement = new CarDescriptionEntity()
                {
                    Description = domainModel.Description,
                    Currency = domainModel.Currency,
                    Image = domainModel.Image,
                    Model = domainModel.Model,
                    Price = domainModel.Price,
                    Year = domainModel.Year,
                    CarFeatures = null
                };
            }

            return statement;
        }

        public static List<CarDescription> AsDomain(this List<CarDescriptionEntity> entities)
        {
            List<CarDescription> statements = new List<CarDescription>();

            foreach (CarDescriptionEntity entity in entities)
            {
                statements.Add(entity.AsDomain());
            };

            return statements;
        }
    }

    public static class CarFeaturesMap
    {
        public static CarFeatures AsDomain(this CarFeaturesEntity entity)
        {
            CarFeatures domainObject = null;
            if (entity != null)
            {
                domainObject = new CarFeatures
                {
                    Id = entity.Id,
                    Features = entity.Features,
                    CarDescriptions = null
                };
            }

            return domainObject;
        }

        public static CarFeaturesEntity AsEntity(this CarFeatures domainModel)
        {
            CarFeaturesEntity statement = null;
            if (domainModel != null)
            {
                statement = new CarFeaturesEntity()
                {
                    Features = domainModel.Features
                };
            }

            return statement;
        }

        public static List<CarFeatures> AsDomain(this List<CarFeaturesEntity> entities)
        {
            List<CarFeatures> statements = new List<CarFeatures>();

            foreach (CarFeaturesEntity entity in entities)
            {
                statements.Add(entity.AsDomain());
            };

            return statements;
        }
    }

    public static class DescriptionFeaturesMap
    {
        public static DescriptionFeaturesEntity AsEntity(this DescriptionFeatures domainModel)
        {
            DescriptionFeaturesEntity statement = null;
            if (domainModel != null)
            {
                statement = new DescriptionFeaturesEntity()
                {
                    CarDescriptionId = domainModel.CarDescriptionId,
                    CarFeaturesId = domainModel.CarFeaturesId
                };
            }

            return statement;
        }

    }
}