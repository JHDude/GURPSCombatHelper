namespace CombatActions

module CombatActionsTypes =
    type Strength = | Strength of int
    type BasicLift = | BasicLift of int
    [<Measure>] type lb
    [<Measure>] type kg
    let lbPerKg = 2.20462<lb/kg>


