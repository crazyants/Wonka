using System;

using Nethereum.Contracts;

namespace WonkaEth.Autogen.WonkaRegistry
{
    public partial class WonkaTestContractDeployment : WonkaTestContractDeploymentBase
    {
        public static string ABI =
@"
[
    {
      ""inputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""constructor""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""key"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""getAttrValueBytes32"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes32""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""ruler"",
          ""type"": ""address""
        },
        {
          ""name"": ""key"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""getAttrValueBytes"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes32""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""saleItemType"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""countryOfSale"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""dummyVal1"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""dummyVal2"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""lookupVATDenominator"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes32""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""arg1"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""arg2"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""arg3"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""arg4"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""performMyCalc"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes32""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""pure"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""key"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""value"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""setAttrValueBytes32"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes32""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""ruler"",
          ""type"": ""address""
        },
        {
          ""name"": ""key"",
          ""type"": ""bytes32""
        },
        {
          ""name"": ""value"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""setAttrValueBytes"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes32""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""x"",
          ""type"": ""bytes32""
        }
      ],
      ""name"": ""bytes32ToString"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""pure"",
      ""type"": ""function""
    }
 ]
";

        public WonkaTestContractDeployment() : base(BYTECODE) { }
        public WonkaTestContractDeployment(string byteCode) : base(byteCode) { }
    }

    public class WonkaTestContractDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052600436106100825763ffffffff7c010000000000000000000000000000000000000000000000000000000060003504166305411ab08114610087578063171f5d83146100b15780635b1af79d146100d257806382047a63146101035780639201de5514610137578063b370860c146101c4578063c3d4a2c7146101df575b600080fd5b34801561009357600080fd5b5061009f600435610200565b60408051918252519081900360200190f35b3480156100bd57600080fd5b5061009f600435602435604435606435610212565b3480156100de57600080fd5b5061009f73ffffffffffffffffffffffffffffffffffffffff600435166024356102c2565b34801561010f57600080fd5b5061009f73ffffffffffffffffffffffffffffffffffffffff6004351660243560443561030b565b34801561014357600080fd5b5061014f600435610358565b6040805160208082528351818301528351919283929083019185019080838360005b83811015610189578181015183820152602001610171565b50505050905090810190601f1680156101b65780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b3480156101d057600080fd5b5061009f60043560243561049e565b3480156101eb57600080fd5b5061009f6004356024356044356064356104b3565b60009081526001602052604090205490565b6000607d818080606089156102ab5761022a8a610358565b90506102378160006105ae565b945088156102ab5761024889610358565b90506102558160006105ae565b9485900394935087156102ab5761026b88610358565b90506102788160006105ae565b94850194925086156102ab5761028d87610358565b905061029a8160006105ae565b915081858115156102a757fe5b0494505b6102b485610710565b9a9950505050505050505050565b6000805473ffffffffffffffffffffffffffffffffffffffff191673ffffffffffffffffffffffffffffffffffffffff9390931692909217825581526001602052604090205490565b6000805473ffffffffffffffffffffffffffffffffffffffff191673ffffffffffffffffffffffffffffffffffffffff949094169390931783559082526001602052604090912081905590565b6040805160208082528183019092526060918291600091829182918591908082016104008038833901905050945060009350600092505b6020831015610404576008830260020a870291507fff000000000000000000000000000000000000000000000000000000000000008216156103f9578185858151811015156103da57fe5b906020010190600160f860020a031916908160001a9053506001909301925b60019092019161038f565b836040519080825280601f01601f191660200182016040528015610432578160200160208202803883390190505b509050600092505b8383101561049457848381518110151561045057fe5b90602001015160f860020a900460f860020a02818481518110151561047157fe5b906020010190600160f860020a031916908160001a90535060019092019161043a565b9695505050505050565b60009182526001602052604090912081905590565b600281905560007f57696467657400000000000000000000000000000000000000000000000000008514801561050857507f554b00000000000000000000000000000000000000000000000000000000000084145b1561053457507f35000000000000000000000000000000000000000000000000000000000000006105a6565b7f576964676574000000000000000000000000000000000000000000000000000085141561058357507f31300000000000000000000000000000000000000000000000000000000000006105a6565b507f32300000000000000000000000000000000000000000000000000000000000005b949350505050565b600082828280805b84518110156107045784517f3000000000000000000000000000000000000000000000000000000000000000908690839081106105ef57fe5b90602001015160f860020a900460f860020a02600160f860020a03191610158015610665575084517f39000000000000000000000000000000000000000000000000000000000000009086908390811061064557fe5b90602001015160f860020a900460f860020a02600160f860020a03191611155b156106be5781156106845783151561067c57610704565b600019909301925b600a830292506030858281518110151561069a57fe5b90602001015160f860020a900460f860020a0260f860020a900403830192506106fc565b84818151811015156106cc57fe5b90602001015160f860020a900460f860020a02600160f860020a031916602e60f860020a0214156106fc57600191505b6001016105b6565b50909695505050505050565b600081801515610742577f3000000000000000000000000000000000000000000000000000000000000000915061077a565b600081111561077a5761010082049150600a810660300160f860020a0260010282179150600a8181151561077257fe5b049050610742565b509190505600a165627a7a7230582066cc57338248b7bfea81c598ddb0505e7a12b79c0e26f6c7210c146babbf76570029";

        public WonkaTestContractDeploymentBase() : base(BYTECODE) { }
        public WonkaTestContractDeploymentBase(string byteCode) : base(byteCode) { }

    }
}

