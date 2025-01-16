import React from "react";
import Login from "./Login";
import { getUserStore } from "@rassilevine/reactutils";

interface Props { element: React.ReactNode, requiredrole: number }

export default function ProtectedRoute({ element, requiredrole }: Props) {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const loggedIn = useUserStore((state => state.isLoggedIn));
    const rolerank = useUserStore((state => state.roleRank));

    const hasPrivelege = rolerank >= requiredrole;
    console.log('rolerank', rolerank);
    console.log('req role', requiredrole);
    if (!loggedIn) {
        console.log('loggedin', loggedIn);
        return <> <Login frompath={location.pathname} /></>
    }
    else if (!hasPrivelege) {
        return <><div>you are not authroized to view this page</div></>
    }
    else {
        return <>{element}</>
    }
}