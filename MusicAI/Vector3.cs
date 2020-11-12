using System;

namespace MusicAI.Vectors {
	public class Vector3 {

		public double x;
		public double y;
		public double z;

		public Vector3 () => new Vector3 (0, 0, 0);

		public Vector3 (double x, double y) => new Vector3 (x, y, 0);

		public Vector3 (double x, double y, double z) {
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector3 operator + (Vector3 a, Vector3 b) {
			return new Vector3 (a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3 operator - (Vector3 a, Vector3 b) {
			return new Vector3 (a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3 operator * (Vector3 a, Vector3 b) {
			return new Vector3 (a.x * b.x, a.y * b.y, a.z * b.z);
		}

		public static Vector3 operator / (Vector3 a, Vector3 b) {
			return new Vector3 (a.x / b.x, a.y / b.y, a.z / b.z);
		}

		public static Vector3 operator + (double a, Vector3 b) {
			return new Vector3 (a + b.x, a + b.y, a + b.z);
		}

		public static Vector3 operator - (double a, Vector3 b) {
			return new Vector3 (a - b.x, a - b.y, a - b.z);
		}

		public static Vector3 operator * (double a, Vector3 b) {
			return new Vector3 (a * b.x, a * b.y, a * b.z);
		}

		public static Vector3 operator / (double a, Vector3 b) {
			return new Vector3 (a / b.x, a / b.y, a / b.z);
		}

		public static Vector3 operator + (Vector3 a, double b) {
			return new Vector3 (a.x + b, a.y + b, a.z + b);
		}

		public static Vector3 operator - (Vector3 a, double b) {
			return new Vector3 (a.x - b, a.y - b, a.z - b);
		}

		public static Vector3 operator * (Vector3 a, double b) {
			return new Vector3 (a.x * b, a.y * b, a.z * b);
		}

		public static Vector3 operator / (Vector3 a, double b) {
			return new Vector3 (a.x / b, a.y / b, a.z / b);
		}

		public double magnitude () {
			return Math.Sqrt (sqrMagnitude ());
		}

		public double sqrMagnitude () {
			return x * x + y * y + z * z;
		}

	}
}
