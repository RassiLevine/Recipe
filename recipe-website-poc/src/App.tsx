
import Navbar from "./Navbar";
import "./assets/css/bootstrap.min (4).css";
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import { Outlet } from "react-router-dom"

export default function App() {
    return (
        <>
            <div className="container">
                <div className="row">
                    <div className="col-12">
                        <Navbar />
                    </div>
                </div>
                <div className="row">
                    <Outlet />
                </div>
            </div>
        </>
    )
}
