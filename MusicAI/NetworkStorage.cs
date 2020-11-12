using System;
using System.IO;

namespace MusicAI.Storage {
	public static class NetworkStorage {

		public static Network Load (string path) {
			if (!File.Exists (path))
				throw new FileNotFoundException ("Could load network because the file location does not exist.", path);
			return new Network (0, 0, 0, 0);
		}

		public static void Save (Network network, string path) {
			if (network == null)
				throw new NullReferenceException ("Could not write network because it doesn't exist.");
		}
	}
}
