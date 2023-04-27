namespace Extensions {

    public static class BoolExtensions {

        public static bool And(this bool boolean, bool condition) => boolean && condition;

        public static bool Or(this bool boolean, bool condition) => boolean || condition;
    }

}