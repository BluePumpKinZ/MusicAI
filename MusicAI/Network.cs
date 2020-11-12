using MusicAI.Storage;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Runtime.Intrinsics;

namespace MusicAI {

	public class Network {

		private int numberOfNodes;
		private int numberOfConnections;
		private int numberOfInputs;
		private int numberOfOutputs;
		private int[] connectionsEnd1;
		private int[] connectionsEnd2;

		public Network (int numberOfNodes, int numberOfConnections, int numberOfInputs, int numberOfOutputs, int[] connectionsEnd1, int[] connectionsEnd2) {
			this.numberOfNodes = numberOfNodes;
			this.numberOfConnections = numberOfConnections;
			this.numberOfInputs = numberOfInputs;
			this.numberOfOutputs = numberOfOutputs;
			if (connectionsEnd1 == null || connectionsEnd2 == null || connectionsEnd1.Length == 0 || connectionsEnd2.Length == 0)
				GenerateNodeNetwork ();
		}

		public Network (int numberOfNodes, int numberOfConnections, int numberofInputs, int numberofOutputs) => new Network (numberOfNodes, numberOfConnections, numberofInputs, numberofOutputs, null, null);

		void GenerateNodeNetwork () {
			
		}

		public void Learn (string dataPath, int iterations) {

		}

		public void Execute (string dataPath, string resultPath, int iterations) {

		}
	}
}
