﻿namespace MultiShop.Catolog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string FeatureSliderCollectionName { get; set; }
        public string ProductDetailsCollectionName { get; set; }
        public string ProductImagesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
