using MusicAI.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicAI {

	class Program {

		static void Main () {

			Console.WriteLine ("Welcome to MusicAI type 'help' to see documentation");

			Network network = null;

			for (; ; ) {

				string input = Console.ReadLine ();
				try {
					List<string> parts = input.Split (" ").ToList ();

					for (int i = 0; i < parts.Count; i++) {
						switch (parts[i].ToLower ()) {
						case "-i": // Create new network
							network = new Network (int.Parse (parts[++i]), int.Parse (parts[++i]), int.Parse (parts[++i]), int.Parse (parts[++i]));
							Console.WriteLine ("Network created.");
							break;
						case "-o": // Open and load network
							network = NetworkStorage.Load (parts[++i]);
							break;
						case "-s": // Save and store network
							NetworkStorage.Save (network, parts[++i]);
							break;
						case "-l": // Let the network learn
							network.Learn (parts[++i], int.Parse (parts[++i]));
							break;
						case "-x": // Use the network for output
							network.Execute (parts[++i], parts[++i], int.Parse (parts[++i]));
							break;
						case "help":
							Console.WriteLine (File.ReadAllText ("Documentation.txt"));
							break;
						case "exit":
							return;
						default:
							Console.WriteLine ("Command not recognized");
							break;
						}
					}
				} catch (Exception e) {
					Console.WriteLine (e);
				}
			}
		}
	}
}
