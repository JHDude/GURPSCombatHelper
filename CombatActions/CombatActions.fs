namespace CombatActions

type CombatActions() = 

    /// <summary>
    /// Given a strength score, calculates basic lift
    /// </summary>
    /// <param name="st"></param>
    member private this.CalcBL (CombatActionsTypes.Strength st) =        
        st * st
        |> (/) 5
        |> CombatActionsTypes.BasicLift
        
    
    member this.ThrowObject st (objWeight : int<CombatActionsTypes.lb>) =
        let bl = (fun (CombatActionsTypes.BasicLift b) -> b) (this.CalcBL st)
        let fbl = float(bl)
        //let fmbl = fbl * 1.0<CombatActionsTypes.lb>
        let wr = float(objWeight) / fbl

        match wr with
        | a when a < 0.05 -> 3.5
        | a when a < 0.1 -> 2.5
        | a when a < 0.15 -> 2.0
        | a when a < 0.2 -> 1.5
        | a when a < 0.25 -> 1.2
        | a when a < 0.3 -> 1.1
        | a when a < 0.4 -> 1.0
        | a when a < 0.5 -> 0.8
        | a when a < 0.75 -> 0.7
        | a when a < 1.0 -> 0.6
        | a when a < 1.5 -> 0.4
        | a when a < 2.0 -> 0.3
        | a when a < 2.5 -> 0.25
        | a when a < 3.0 -> 0.2
        | a when a < 4.0 -> 0.15
        | a when a < 5.0 -> 0.12
        | a when a < 6.0 -> 0.1
        | a when a < 7.0 -> 0.09
        | a when a < 8.0 -> 0.08
        | a when a < 9.0 -> 0.07
        | a when a < 10.0 -> 0.06
        | _ -> 0.05
        |> (*) (float((fun (CombatActionsTypes.Strength s) -> s) st))


