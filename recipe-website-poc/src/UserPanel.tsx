import { Link } from "react-router-dom";
// import { useUserStore } from "./UserStore/User"
import { getUserStore } from "@rassilevine/reactutils"

export default function UserPanel() {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const username = useUserStore((state => state.userName));
    const rolename = useUserStore((state => state.roleName));
    const roleRank = useUserStore((state => state.roleRank));
    const isLoggedIn = useUserStore((state => state.isLoggedIn));
    const logout = useUserStore((state => state.logout));


    return (
        <div>
            {isLoggedIn ? (
                <div>
                    <p>Welcome {username}! role:{rolename} roleRank:{roleRank}</p>
                    <button onClick={() => logout(username)}>Logout</button>
                </div>
            ) : (
                <>
                    <Link className="nav-link" to="/login">Login</Link>
                </>
            )}
        </div>
    )
}
