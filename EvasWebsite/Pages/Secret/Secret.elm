import Html exposing (...)

type alias Model = {...}

type Msg = Reset | ...

update : Msg -> Model -> Model
update msg model =
    case msg of
        Reset -> ...
        ...

view : Model -> Html Msg
view model = 
    ...




