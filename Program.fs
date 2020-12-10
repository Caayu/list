open System

[<EntryPoint>]
let main argv =
    let mutable name = ""
    printf "Digite o nome dos seus amigos. Digite 'sair' quando quiser sair do programa.\n"
    let names = [
        while name <> "sair" do
            name <- Console.ReadLine()
            if name <> "sair" then
                yield name
    ]
    printf "Voce tem %d amigos!\n" names.Length
    printf "===============================\n"
    // printf "Nome dos amigos digitados\n"
    // names
    // |> List.iter(fun n -> printf " - %s" n)
    names
    |> List.map(fun n -> "Ola, " + n)
    |> List.iter(fun welcome -> printf "%s \n" welcome)
    0
