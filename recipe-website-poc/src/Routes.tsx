import { createBrowserRouter } from "react-router-dom";
import App from "./App";
import Cookbooks from "./Cookbooks";
import Meals from "./Meals";
import Recipes from "./recipes";
import React from "react";
import ProtectedRoute from "./ProtectedRoute";
import Welcome from "./Welcome";
import Login from "./Login";
import UserPanel from "./UserPanel";

const router = createBrowserRouter(
    [
        {
            path: "/", element: <App />, children: [
                { index: true, element: <Welcome /> },
                { path: "recipes", element: <Recipes /> },
                { path: "login", element: <Login frompath={location.pathname} /> },
                { path: "recipes", element: <ProtectedRoute requiredrole={0} element={<Recipes />} /> },
                { path: "cookbooks", element: <ProtectedRoute requiredrole={0} element={<Cookbooks />} /> },
                { path: "meals", element: <ProtectedRoute requiredrole={3} element={<Meals />} /> },
            ]
        }
    ]
)

export default router

