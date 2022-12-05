using System.ComponentModel;

namespace CategoryEnum.Enums;

public enum Category
    {
        [Description("Cake Pops")] CakePops = 1,

        Brownies,

        [Description("Cinnamon Rolls")] CinnamonRolls = 3,

        Cookies,

        Cupcakes,

        Pretzels
    }