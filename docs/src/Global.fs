module Global

let [<Literal>] libVersion = "v1.3.2"

type Page =
    | Home
    | Installation
    | Usage
    | AppBar
    | Avatars
    | Buttons
    // TODO Add other demos

type NavItem = {
    Title : string
    Children : NavItem list
    Href : Page option
}

let toHash page =
    match page with
    | Home -> "#/home"
    | Installation -> "#/getting-started/installation"
    | Usage -> "#/getting-started/usage"
    | AppBar -> "#/demos/app-bar"
    | Avatars -> "#/demos/avatars"
    | Buttons -> "#/demos/buttons"

let toTitle = function
    | Home -> ""
    | Installation -> "Installation"
    | Usage -> "Usage"
    | AppBar -> "App Bar"
    | Avatars -> "Avatars"
    | Buttons -> "Buttons"
