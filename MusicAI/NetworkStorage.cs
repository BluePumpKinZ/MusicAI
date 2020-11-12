using System;
using System.IO;

namespace MusicAI.Storage {
	public static class NetworkStorage {

		public static Network Load (string path) {
			if (!File.Exists (path)) {
				Console.WriteLine ("Could load network because the file location does not exist.");

			}
			return new Network (0, 0, 0, 0);
		}

		public static void Save (Network network, string path) {
			if (network == null) {
				Console.WriteLine ("Could not write network because it doesn't exist.");
				return;
			}
		}
	}
}
