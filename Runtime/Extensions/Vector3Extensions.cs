using System.Numerics;

namespace Holypastry.Bakery
{
    public static class Vector3Extensions
    {

        public static Vector3 With(this Vector3 vector, float? x = null, float? y = null, float? z = null)
        {
            return new Vector3(x ?? vector.X, y ?? vector.Y, z ?? vector.Z);
        }

        public static Vector3 Add(this Vector3 vector, float? x = null, float? y = null, float? z = null)
        {
            return new Vector3(vector.X + (x ?? 0), vector.Y + (y ?? 0), vector.Z + (z ?? 0));
        }

    }
}
