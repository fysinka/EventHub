
namespace EventHub.Common.Constants
{
    public static class EntityValidationConstants
    {
        public static class Event
        {
            public const int TitleMinLength = 5;
            public const int TitleMaxLength = 100;

            public const int DescriptionMinLength = 20;
            public const int DescriptionMaxLength = 2000;

            public const int CapacityMinValue = 1;
            public const int CapacityMaxValue = 10000;

            public const int ImageUrlMaxLength = 2048;
        }

        public static class Category
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;
        }

        public static class Venue
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 200;

            public const int CityMinLength = 2;
            public const int CityMaxLength = 100;
        }

        public static class Review
        {
            public const int CommentMinLength = 10;
            public const int CommentMaxLength = 1000;

            public const int RatingMinValue = 1;
            public const int RatingMaxValue = 5;
        }
    }
}
