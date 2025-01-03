import { createBrowserRouter } from "react-router-dom";
import App from "./App";
import Cookbooks from "./Cookbooks";
import Meals from "./Meals";
import Recipes from "./recipes";

const router = createBrowserRouter(
    [
        {
            path: "/", element: <App />, children: [
                // { index: true, element: <App /> },
                // { path: "/app", element: <App /> },
                { index: true, element: <Recipes /> },
                { path: "/recipes", element: <Recipes /> },
                { path: "/cookbooks", element: <Cookbooks /> },
                { path: "/meals", element: <Meals /> },
            ]
        }
    ]
)

export default router

